namespace PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine().Split().ToList();
            var endCommand = "Party!";
            Func<string, string, bool> myStartsWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> myEndsWith = (a, b) => a.EndsWith(b);
            Func<string, int, bool> lenghtChecker = (a, b) => a.Length == b;
            var command = Console.ReadLine();
            while (command != endCommand)
            {
                var commandArgs = command.Split();
                var instruction = commandArgs[0].ToLower();
                var criteria = commandArgs[1];
                var criteriaValue = commandArgs[2];

                if (instruction == "double")
                {
                    var namesToAdd = new List<string>();
                    switch (criteria)
                    {
                        case "StartsWith":
                            namesToAdd = guests.Where(x => myStartsWith(x, criteriaValue)).ToList();
                            break;
                        case "EndsWith":
                            namesToAdd = guests.Where(x => myEndsWith(x, criteriaValue)).ToList();
                            break;
                        case "Length":
                            namesToAdd = guests.Where(x => lenghtChecker(x, int.Parse(criteriaValue))).ToList();
                            break;
                    }

                    AddsGuests(guests, namesToAdd);
                }
                else if (instruction == "remove")
                {
                    switch (criteria)
                    {
                        case "StartsWith":
                            guests = guests.Where(x => !myStartsWith(x, criteriaValue)).ToList();
                            break;
                        case "EndsWith":
                            guests = guests.Where(x => !myEndsWith(x, criteriaValue)).ToList();
                            break;
                        case "Length":
                            guests = guests.Where(x => !lenghtChecker(x, int.Parse(criteriaValue))).ToList();
                            break;
                    }
                }

                command = Console.ReadLine();
            }

            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{ string.Join(", ", guests)} are going to the party!");
            }
        }

        private static void AddsGuests(List<string> guests, List<string> namesToAdd)
        {
            foreach (var name in namesToAdd)
            {
                var index = guests.IndexOf(name);
                guests.Insert(index, name);
            }
        }
    }
}
