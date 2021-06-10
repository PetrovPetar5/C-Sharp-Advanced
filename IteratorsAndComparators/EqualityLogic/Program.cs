namespace EqualityLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            var n = byte.Parse(Console.ReadLine());
            var peopleSet = new HashSet<Person>();
            var peopleSortedSet = new SortedSet<Person>();
            for (int i = 0; i < n; i++)
            {
                var commandArgs = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                var name = commandArgs[0];
                var age = int.Parse(commandArgs[1]);
                var person = new Person(name, age);
                peopleSet.Add(person);
                peopleSortedSet.Add(person);
            }

            Console.WriteLine(peopleSet.Count);
            Console.WriteLine(peopleSortedSet.Count);
        }
    }
}
