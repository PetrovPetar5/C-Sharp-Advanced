namespace SortEvenNumbers
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var numberInput = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                 .Where(x => x % 2 == 0)
                 .OrderBy(x=>x)
                 .ToArray();

            Console.WriteLine(String.Join(", ", numberInput));
        }
    }
}
