using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> peopleHash = new HashSet<Person>();
            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();
            var inputLinesToFollow = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputLinesToFollow; i++)
            {
                try
                {
                    var inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    var name = inputArgs[0];
                    var age = int.Parse(inputArgs[0]);
                    Person cuPerson = new Person(name, age);
                    peopleHash.Add(cuPerson);
                    peopleSortedSet.Add(cuPerson);
                }
                catch (ArgumentException msg)
                {


                }

            }

            Console.WriteLine(peopleSortedSet.Count);
            Console.WriteLine(peopleHash.Count);
        }
    }
}
