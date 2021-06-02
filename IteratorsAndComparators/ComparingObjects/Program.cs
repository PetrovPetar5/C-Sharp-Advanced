using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var command = String.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                var commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                AddsPersonToList(people, commandArgs);
            }

            var n = int.Parse(Console.ReadLine());
            var personToCompare = people[n - 1];
            var matchesCount = 0;
            foreach (var person in people)
            {
                if (person.Equals(personToCompare))
                {
                    matchesCount++;
                }
            }

            var totalPeopleInList = people.Count;
            var differentToPerson = people.Count - matchesCount;
            if (matchesCount <= 1)
            {
                Console.WriteLine("No matches");

            }
            else
            {
                Console.WriteLine($"{matchesCount} {differentToPerson} {totalPeopleInList}");
            }
        }

        private static void AddsPersonToList(List<Person> personList, string[] commandArgs)
        {
            var name = commandArgs[0];
            var age = int.Parse(commandArgs[1]);
            var town = commandArgs[2];
            Person curPerson = new Person(name, age, town);
            personList.Add(curPerson);
        }
    }
}
