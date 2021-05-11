namespace CustomMinFunction
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> myMin = numbers =>
             {
                 var minValue = int.MaxValue;
                 foreach (var number in numbers)
                 {
                     if (number < minValue)
                     {
                         minValue = number;
                     }
                 }

                 return minValue;
             };

            Console.WriteLine(myMin(numbers));
        }
    }
}
