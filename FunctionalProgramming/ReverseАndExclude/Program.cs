namespace ReverseАndExclude
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var divider = int.Parse(Console.ReadLine());
            var loopsCount = numbers.Count / 2;
            Predicate<int> isDividedBy = x => x % divider == 0;

            for (int i = 0; i < loopsCount; i++)
            {
                var temp = numbers[i];
                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = temp;
            };

            numbers.RemoveAll(isDividedBy);
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
