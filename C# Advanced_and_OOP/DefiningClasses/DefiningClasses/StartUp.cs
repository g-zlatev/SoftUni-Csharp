using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int age = 0;
            string name = "";

            Family family = new Family();

            List<Person> overThirty = new List<Person>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                name = input[0];
                age = int.Parse(input[1]);

                Person person = new Person(name, age);

                family.AddMember(person);

                if (person.Age > 30)
                {
                    overThirty.Add(person);
                }
            }

            overThirty = overThirty.OrderBy(x => x.Name).ToList();


            //foreach (var pers in overThirty)
            //{
            //    Console.WriteLine($"{pers.Name} - {pers.Age}");

            //}

            Console.WriteLine(string.Join(Environment.NewLine, overThirty));

        }
    }
}
