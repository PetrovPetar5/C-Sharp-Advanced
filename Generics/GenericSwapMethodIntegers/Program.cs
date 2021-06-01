namespace GenericSwapMethodIntegers
{
    using Box;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var inputCount = int.Parse(Console.ReadLine());
            var boxes = new List<Box<int>>();
            for (int i = 0; i < inputCount; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var curBox = new Box<int>(input);
                boxes.Add(curBox);
            }

            var indiceInput = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
            Box<int>.Swap(indiceInput, boxes);

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
