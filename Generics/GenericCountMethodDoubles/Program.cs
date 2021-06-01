namespace GenericCountMethodDoubles
{
    using Box;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(Console.ReadLine());
            var inputElements = new List<double>();
            for (int i = 0; i < numbersCount; i++)
            {
                var curElement = double.Parse(Console.ReadLine());
                inputElements.Add(curElement);
            }

            var cryteria = double.Parse(Console.ReadLine());
            var greaterElementsCount = Box<double>.CountGreaterElements(inputElements, cryteria);
            Console.WriteLine(greaterElementsCount);
        }
    }
}
