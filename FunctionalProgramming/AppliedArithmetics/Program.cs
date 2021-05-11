namespace AppliedArithmetics
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Func<double[], double[]> operation = null;
            var command = String.Empty;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                switch (command)
                {
                    case "add":
                        operation = numbers => numbers.Select(x => x + 1).ToArray();
                        break;
                    case "subtract":
                        operation = numbers => numbers.Select(x => x - 1).ToArray();
                        break;
                    case "multiply":
                        operation = numbers => numbers.Select(x => x * 2).ToArray();
                        break;
                    case "print":
                        Console.WriteLine(String.Join(" ", numbers));
                        break;
                }

                numbers = ApplyCommand(numbers, operation);
            }
        }

        private static double[] ApplyCommand(double[] arr, Func<double[], double[]> operation)
        {
            var result = operation(arr);
            return result;
        }
    }
}
