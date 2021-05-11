namespace FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var lineCount = int.Parse(Console.ReadLine());
            var people = new HashSet<Person>();
            AddPerson(lineCount, people);
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var @format = Console.ReadLine().Split();
            var peopleByCondition = ReturnsPeopleByCondition(condition, age, people);
            var result = ReturnsResultAsPerGivenFormat(format, peopleByCondition);
            Console.WriteLine(result);
        }

        private static string ReturnsResultAsPerGivenFormat(string[] format, IEnumerable<Person> peopleByCondition)
        {
            var sb = new StringBuilder();
            if (@format.Count() > 1)
            {
                foreach (var person in peopleByCondition)
                {
                    sb.AppendLine($"{person.Name} - {person.Age}");
                }
            }
            else if (@format[0].StartsWith("n"))
            {
                foreach (var person in peopleByCondition)
                {
                    sb.AppendLine($"{person.Name}");
                }
            }
            else
            {
                foreach (var person in peopleByCondition)
                {
                    sb.AppendLine($"{person.Age}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        private static IEnumerable<Person> ReturnsPeopleByCondition(string condition, int age, HashSet<Person> people)
        {
            var peopleByCondition = new HashSet<Person>();
            if (condition == "younger")
            {
                peopleByCondition = people.Where(x => x.Age < age).ToHashSet();
            }
            else if (condition == "older")
            {
                peopleByCondition = people.Where(x => x.Age >= age).ToHashSet();
            }

            return peopleByCondition;
        }

        private static void AddPerson(int lineCount, HashSet<Person> people)
        {
            for (int i = 0; i < lineCount; i++)
            {
                var curPersonInput = Console.ReadLine().Split(", ");
                var name = curPersonInput[0];
                var age = int.Parse(curPersonInput[1]);
                var curPerson = new Person(name, age);
                people.Add(curPerson);
            }
        }
    }
}
