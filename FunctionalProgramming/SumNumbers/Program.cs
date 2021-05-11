namespace SumNumbers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            Console.WriteLine(inputNumbers.Sum());
            Console.WriteLine(inputNumbers.Count());
        }
    }
}
