using System;
using System.Linq;
using System.Collections.Generic;

using P07_Military_Elite.Models;
using P07_Military_Elite.Contracts;
using P07_Military_Elite.Exceptions;
using P07_Military_Elite.Core.Contracts;
using P07_Military_Elite.Models.Soldiers;
using P07_Military_Elite.Core.IO.Contracts;

namespace P07_Military_Elite.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private ICollection<ISoldier> soldiers;

        public Engine()
        {
            this.soldiers = new List<ISoldier>();
        }

        public Engine(IReader reader, IWriter writer)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" ", System.StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string solderType = cmdArgs[0];
                int id = int.Parse(cmdArgs[1]);
                string firstName = cmdArgs[2];
                string lastName = cmdArgs[3];

                ISoldier soldier = null;

                if (solderType == "Private")
                {
                    soldier = AddPrivate(cmdArgs, id, firstName, lastName);
                }
                else if (solderType == "LieutenantGeneral")
                {
                    soldier = AddGeneral(cmdArgs, id, firstName, lastName);
                }
                else if (solderType == "Engineer")
                {
                    decimal salary = decimal.Parse(cmdArgs[4]);
                    string corps = cmdArgs[5];

                    try
                    {
                        IEngineer enginer = CreateEngineer(cmdArgs, id, firstName, lastName, salary, corps);
                        soldier = enginer;
                    }
                    catch (InvalidCorpsException ice)
                    {
                        continue;
                    }
                }
                else if (solderType == "Commando")
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
                else if (solderType == "Spy")
                {
                    int codeNumber = int.Parse(cmdArgs[4]);
                    soldier = new Spy(id, firstName, lastName, codeNumber);
                }

                if (soldier != null)
                {
                    this.soldiers.Add(soldier);
                }
            }

            foreach (var soldier in this.soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }

        private static ICommando GetCommando(string[] cmdArgs, int id, string firstName, string lastName, decimal salary, string corps)
        {
            ICommando commando = new Commando(id, firstName, lastName, salary, corps);

            string[] missionArgs = cmdArgs
                .Skip(6)
                .ToArray();

            for (int i = 0; i < missionArgs.Length; i += 2)
            {
                try
                {
                    string missionCodeName = missionArgs[i];
                    string missionState = missionArgs[i + 1];

                    IMission mission = new Mission(missionCodeName, missionState);
                    commando.AddMission(mission);
                }
                catch (InvalidMissionStateException imse)
                {
                    continue;
                }
            }

            return commando;
        }

        private static IEngineer CreateEngineer(string[] cmdArgs, int id, string firstName, string lastName, decimal salary, string corps)
        {
            IEngineer enginer = new Engineer(id, firstName, lastName, salary, corps);

            string[] repairArgs = cmdArgs
                .Skip(6)
                .ToArray();

            for (int i = 0; i < repairArgs.Length; i += 2)
            {
                string partName = repairArgs[i];
                int hoursWorked = int.Parse(repairArgs[i + 1]);

                IRepair repair = new Repair(partName, hoursWorked);
                enginer.AddRepair(repair);
            }

            return enginer;
        }

        private ISoldier AddGeneral(string[] cmdArgs, int id, string firstName, string lastName)
        {
            ISoldier soldier;
            decimal salary = decimal.Parse(cmdArgs[4]);
            ILieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);

            foreach (var pid in cmdArgs.Skip(5))
            {
                ISoldier privateToAdd = this.soldiers.First(s => s.Id == int.Parse(pid));
                general.AddPrivate(privateToAdd);
            }

            soldier = general;
            return soldier;
        }

        private static ISoldier AddPrivate(string[] cmdArgs, int id, string firstName, string lastName)
        {
            ISoldier soldier;
            decimal salary = decimal.Parse(cmdArgs[4]);
            soldier = new Private(id, firstName, lastName, salary);
            return soldier;
        }
    }
}
