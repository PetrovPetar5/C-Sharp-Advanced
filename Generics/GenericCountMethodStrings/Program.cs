namespace GenericCountMethodStrings
{
    using System;
    using System.Collections.Generic;
    using Box;

    class Program
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(Console.ReadLine());
            var inputElements = new List<string>();
            for (int i = 0; i < numbersCount; i++)
            {
                var curElement = Console.ReadLine();
                inputElements.Add(curElement);
            }

            var cryteria = Console.ReadLine();
            var greaterElementsCount = Box<string>.CountGreaterElements(inputElements, cryteria);
            Console.WriteLine(greaterElementsCount);
        }
    }
}
