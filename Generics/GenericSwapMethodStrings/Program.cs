namespace GenericSwapMethodStrings
{
    using Box;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            var inputCount = int.Parse(Console.ReadLine());
            var boxes = new List<Box<string>>();
            for (int i = 0; i < inputCount; i++)
            {
                var input = Console.ReadLine();
                var curBox = new Box<string>(input);
                boxes.Add(curBox);
            }

            var indiceInput = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();
            Box<string>.Swap(indiceInput, boxes);

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
