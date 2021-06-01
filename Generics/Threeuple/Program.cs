namespace Threeuple
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {

        }

        private static string[] ReturnUserInputAsArray()
        {
            var userInput = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToArray();

            return userInput;
        }

        private static Threeuple<string, string, string> ReturnsFullnameAndAddress(string[] userInput)
        {


            var fullname = userInput[0] + " " + userInput[1];
            var address = userInput[2];
            var town = userInput[3];

            var nameAddress = new Threeuple<string, string, string>(fullname, address, town);

            return nameAddress;
        }

        private static Threeuple<string, int, string> ReturnsFirstNameLittersBeer(string[] userInput)
        {
            var firstName = userInput[0];
            var beerLitters = int.Parse(userInput[1]);
            var drunkOrNot = userInput[2].ToLower() == "drunk" ? true : false;

            var firstNameBeerLitters = new Threeuple<string, int, string>(firstName, beerLitters, drunkOrNot.ToString());

            return firstNameBeerLitters;
        }

        private static Threeuple<string, decimal, string> ReturnsIntDoubleData(string[] userInput)
        {
            var firstName = userInput[0];
            var accountBalance = decimal.Parse(userInput[1]);
            var bankName = userInput[2];

            var intDouleFigure = new Threeuple<string, decimal,string>(firstName, accountBalance, bankName);

            return intDouleFigure;
        }

        private static void AddsLineToString<T1, T2,T3>(StringBuilder sb, Threeuple<T1, T2,T3> threeuple)
        {
            sb.AppendLine($"{threeuple.FirstElement} -> {threeuple.SecondElement} -> {threeuple.ThirdElement}");
        }
    }
}
