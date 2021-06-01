namespace Tuple
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var userInput = ReturnUserInputAsArray();
            var nameAddress = ReturnsFullnameAndAddress(userInput);

            userInput = ReturnUserInputAsArray();
            var nameBeerDrunk = ReturnsFirstNameLittersBeer(userInput);

            userInput = ReturnUserInputAsArray();
            var intDoubleInput = ReturnsIntDoubleData(userInput);

            var sb = new StringBuilder();
            AddsLineToString(sb, nameAddress);
            AddsLineToString(sb, nameBeerDrunk);
            AddsLineToString(sb, intDoubleInput);

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static string[] ReturnUserInputAsArray()
        {
            var userInput = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToArray();

            return userInput;
        }

        private static OwnTuple<string, string> ReturnsFullnameAndAddress(string[] userInput)
        {


            var fullname = userInput[0] + " " + userInput[1];
            var address = userInput[2];

            var nameAddress = new OwnTuple<string, string>(fullname, address);

            return nameAddress;
        }

        private static OwnTuple<string, int> ReturnsFirstNameLittersBeer(string[] userInput)
        {
            var firstName = userInput[0];
            var beerLitters = int.Parse(userInput[1]);

            var firstNameBeerLitters = new OwnTuple<string, int>(firstName, beerLitters);

            return firstNameBeerLitters;
        }

        private static OwnTuple<int, double> ReturnsIntDoubleData(string[] userInput)
        {
            var intFifureInput = int.Parse(userInput[0]);
            var doubleFigureInput = double.Parse(userInput[1]);

            var intDouleFigure = new OwnTuple<int, double>(intFifureInput, doubleFigureInput);

            return intDouleFigure;
        }

        private static void AddsLineToString<T1, T2>(StringBuilder sb, OwnTuple<T1, T2> tuple)
        {
            sb.AppendLine($"{tuple.FirstValue} -> {tuple.SecondValue}");
        }
    }
}

