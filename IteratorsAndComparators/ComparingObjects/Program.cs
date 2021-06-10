namespace ComparingObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var endCommand = "END";
            var command = Console.ReadLine();
            var people = new List<Person>();
            while (command != endCommand)
            {
                var commandArgs = command
                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                  .ToArray();
                var personName = commandArgs[0];
                var personAge = byte.Parse(commandArgs[1]);
                var personTown = commandArgs[2];
                var curPerson = new Person(personName, personAge, personTown);
                people.Add(curPerson);
                command = Console.ReadLine();
            }

            var personToCompareIndex = byte.Parse(Console.ReadLine()) - 1;
            var targetPerson = people[personToCompareIndex];
            var equalPeopleCount = 1;
            var totalPeopleCount = people.Count();
            foreach (var person in people)
            {
                if (!person.Equals(targetPerson) && person.CompareTo(targetPerson) == 0)
                {
                    equalPeopleCount++;
                }
            }

            if (equalPeopleCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeopleCount} {totalPeopleCount - equalPeopleCount} {totalPeopleCount}");
            }
        }
    }
}
