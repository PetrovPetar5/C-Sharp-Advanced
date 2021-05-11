namespace AddVAT
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var vAT = 1.2;
            Func<double, double> addingVat = x => x * vAT;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                var vatFigure = addingVat(inputNumbers[i]);
                inputNumbers[i] = vatFigure;
            }

            Console.WriteLine(String.Join(Environment.NewLine, inputNumbers.Select(x => x.ToString("F2"))));
        }
    }
}
