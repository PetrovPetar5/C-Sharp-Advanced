namespace ListOfPredicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var endNumber = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int, bool> validDivider = (x, y) => x % y == 0;
            var result = new List<int>();
            var isValid = true;
            for (int i = 1; i <= endNumber; i++)
            {
                var curNumber = i;
                isValid = ChecksEachDivider(dividers, validDivider, curNumber);

                if (isValid)
                {
                    result.Add(curNumber);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }

        private static bool ChecksEachDivider(int[] dividers, Func<int, int, bool> validDivider, int curNumber)
        {
            for (int j = 0; j < dividers.Length; j++)
            {
                if (!validDivider(curNumber, dividers[j]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
