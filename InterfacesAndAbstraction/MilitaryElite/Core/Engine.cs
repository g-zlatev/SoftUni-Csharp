using System;
using System.Linq;
using System.Collections.Generic;

using MilitaryElite.Contracts;
using MilitaryElite.Core.Contracts;
using MilitaryElite.IO.Contracts;
using MilitaryElite.Models;
using MilitaryElite.Exceptions;

namespace MilitaryElite.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private ICollection<ISoldier> soldiers;

        private Engine()
        {
            this.soldiers = new List<ISoldier>();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string command;

            while ((command = this.reader.ReadLine()) != "End")
            {
                var cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                var soldierType = cmdArgs[0];
                int id = int.Parse(cmdArgs[1]);
                string firstName = cmdArgs[2];
                string lastName = cmdArgs[3];


                ISoldier soldier = null;

                if (soldierType == "Private")
                {
                    soldier = AddPrivate(cmdArgs, id, firstName, lastName);
                }

                else if (soldierType == "LieutenantGeneral")
                {
                    soldier = AddLieutenantGeneral(cmdArgs, id, firstName, lastName);
                }

                else if (soldierType == "Engineer")
                {
                    decimal salary = decimal.Parse(cmdArgs[4]);
                    string corps = cmdArgs[5];

                    try
                    {
                        IEngineer engineer = CreateEngineer(cmdArgs, id, firstName, lastName, salary, corps);

                        soldier = engineer;
                    }
                    catch (InvalidCorpsException ice)
                    {
                        continue;
                    }

                }

                else if (soldierType == "Commando")
                {
                    decimal salary = decimal.Parse(cmdArgs[4]);
                    string corps = cmdArgs[5];

                    try
                    {
                        ICommando commando = GetCommando(cmdArgs, id, firstName, lastName, salary, corps);

                        soldier = commando;

                    }
                    catch (InvalidCorpsException ice)
                    {
                        continue;
                    }

                }

                else if (soldierType == "Spy")
                {
                    int codeNum = int.Parse(cmdArgs[4]);

                    soldier = new Spy(id, firstName, lastName, codeNum);
                }

                if (soldier != null)
                {
                    this.soldiers.Add(soldier);
                }

            }

            foreach (var soldier in soldiers)
            {
                this.writer.WriteLine(soldier.ToString());
            }
        }

        private static ICommando GetCommando(string[] cmdArgs, int id, string firstName, string lastName, decimal salary, string corps)
        {
            ICommando commando = new Commando(id, firstName, lastName, salary, corps);

            var missionArgs = cmdArgs.Skip(6).ToArray();

            for (int i = 0; i < missionArgs.Length; i += 2)
            {
                try
                {
                    string missionName = missionArgs[i];
                    string state = missionArgs[i + 1];

                    IMission mission = new Mission(missionName, state);
                    commando.AddMission(mission);

                }
                catch (InvalidStateException ise)
                {
                    continue;
                }
            }

            return commando;
        }

        private static IEngineer CreateEngineer(string[] cmdArgs, int id, string firstName, string lastName, decimal salary, string corps)
        {
            IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

            var partArgs = cmdArgs.Skip(6).ToArray();

            for (int i = 0; i < partArgs.Length; i += 2)
            {
                string name = partArgs[i];
                int hours = int.Parse(partArgs[i + 1]);

                IRepair part = new Repair(name, hours);
                engineer.AddRepair(part);
            }

            return engineer;
        }

        private ISoldier AddLieutenantGeneral(string[] cmdArgs, int id, string firstName, string lastName)
        {
            ISoldier soldier;
            decimal salary = decimal.Parse(cmdArgs[4]);

            ILieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);

            foreach (var PrivId in cmdArgs.Skip(5))
            {
                ISoldier priv = this.soldiers.First(s => s.Id == int.Parse(PrivId));

                general.AddPrivate(priv);
            }

            soldier = general;
            return soldier;
        }

        private ISoldier AddPrivate(string[] cmdArgs, int id, string firstName, string lastName)
        {
            ISoldier soldier;
            decimal salary = decimal.Parse(cmdArgs[4]);
            soldier = new Private(id, firstName, lastName, salary);

            return soldier;
        }
    }
}
