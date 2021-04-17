namespace TeisterMask.DataProcessor
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using Data;
    using Newtonsoft.Json;
    using TeisterMask.Data.Models;
    using TeisterMask.Data.Models.Enums;
    using TeisterMask.DataProcessor.ImportDto;
    using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedProject
            = "Successfully imported project - {0} with {1} tasks.";

        private const string SuccessfullyImportedEmployee
            = "Successfully imported employee - {0} with {1} tasks.";

        public static string ImportProjects(TeisterMaskContext context, string xmlString)
        {
            var projects = XmlConverter.Deserializer<ProjectsInputModel>(xmlString, "Projects");
            //var tasks = XmlConverter.Deserializer<TasksInputModel>(xmlString, "Tasks");

            var sb = new StringBuilder();

            var validProjects = new List<Project>();

            foreach (var proj in projects)
            {
                if (!IsValid(proj))
                {
                    sb.AppendLine("Invalid Data!");
                    continue;
                }

                var projOpenDate = DateTime.ParseExact(proj.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                var isValidProjDueDate = DateTime.TryParseExact(proj.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dueDate);

                //var project = new Project
                //{
                //    Name = proj.Name,
                //    OpenDate = projOpenDate,
                //    DueDate = isValidProjDueDate ? (DateTime?)dueDate : null,
                //    Tasks = proj.Tasks.Select(x => new Task
                //    {
                //        Name = x.Name,
                //        OpenDate = DateTime.ParseExact(x.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                //        DueDate = DateTime.ParseExact(x.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                //        ExecutionType = Enum.Parse<ExecutionType>(x.ExecutionType),
                //        LabelType = Enum.Parse<LabelType>(x.LabelType)
                //    }).ToList()
                //};


                var project = new Project
                {
                    Name = proj.Name,
                    OpenDate = projOpenDate,
                    DueDate = isValidProjDueDate ? (DateTime?)dueDate : null,

                };
                foreach (var projTask in proj.Tasks)
                {
                    if (!IsValid(projTask))
                    {
                        sb.AppendLine("Invalid Data!");
                        continue;
                    }

                    var taskOpenDate = DateTime.ParseExact(projTask.OpenDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    var taskDueDate = DateTime.ParseExact(projTask.DueDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    if (taskOpenDate < project.OpenDate || taskDueDate < project.DueDate)
                    {
                        sb.AppendLine("Invalid Data!");
                        continue;
                    }

                    project.Tasks.Add(new Task
                    {
                        Name = projTask.Name,
                        OpenDate = taskOpenDate,
                        DueDate = taskDueDate,
                        ExecutionType = Enum.Parse<ExecutionType>(projTask.ExecutionType),
                        LabelType = Enum.Parse<LabelType>(projTask.LabelType),
                        Project = project
                    });

                }

                validProjects.Add(project);
                sb.AppendLine($"Successfully imported project - {project.Name} with {project.Tasks.Count()} tasks.");

            }

            context.Projects.AddRange(validProjects);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportEmployees(TeisterMaskContext context, string jsonString)
        {
            var sb = new StringBuilder();
            //var employees = new List<Employee>();

            var EmployeesTasks = JsonConvert.DeserializeObject<IEnumerable<EmployeeInputModel>>(jsonString);

            foreach (var employeeTask in EmployeesTasks)
            {
                if (!IsValid(employeeTask))
                {
                    sb.AppendLine("Invalid Data!");
                    continue;
                }

                var employee = new Employee
                {
                    Username = employeeTask.Username,
                    Email = employeeTask.Email,
                    Phone = employeeTask.Phone,
                };

                foreach (var task in employeeTask.Tasks)
                {
                    var validateTask = context.Tasks.FirstOrDefault(x => x.Id == task);
                    if (validateTask == null)
                    {
                        sb.AppendLine("Invalid Data!");
                        continue;
                    }

                    if (context.Tasks.Any(x => x.Id == task))
                    {
                        continue;
                    }

                    employee.EmployeesTasks.Add(new EmployeeTask { TaskId = task });
                }

                context.Employees.Add(employee);
                context.SaveChanges();
                sb.AppendLine($"Successfully imported employee - {employee.Username} with {employee.EmployeesTasks.Count} tasks.");
            }

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}