namespace FindEvensOrOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cryteria = Console.ReadLine().ToLower();
            var lowerBand = range[0];
            var upperBand = range[1];
            Predicate<int> evenChecker = number => number % 2 == 0;
            var numbers = ReturnsEvenOrOddSequence(cryteria, evenChecker, lowerBand, upperBand);
            Console.WriteLine(String.Join(" ", numbers));
        }
        private static IEnumerable<int> ReturnsEvenOrOddSequence(string cryteria, Predicate<int> evenChecker, int lowerBand, int upperBand)
        {
            var numbers = new HashSet<int>();
            if (cryteria == "even")
            {
                for (int i = lowerBand; i <= upperBand; i += 2)
                {
                    if (evenChecker(i))
                    {
                        numbers.Add(i);
                    }
                }
            }
            else
            {
                for (int i = lowerBand; i <= upperBand; i++)
                {
                    if (evenChecker(i))
                    {
                        continue;
                    }

                    numbers.Add(i);
                }
            }

            return numbers;
        }
    }
}
