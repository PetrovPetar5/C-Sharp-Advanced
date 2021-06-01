namespace Threeuple
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var userInput = ReturnUserInputAsArray();
            var nameAddressTown = ReturnsFullnameAddressTown(userInput);

            userInput = ReturnUserInputAsArray();
            var nameBeerDrunk = ReturnsFirstNameLittersBeerDrunkOrNot(userInput);

            userInput = ReturnUserInputAsArray();
            var nameAccBalanceBank = ReturnsNameAccountBalanceBankName(userInput);

            var sb = new StringBuilder();
            AddsLineToString(sb, nameAddressTown);
            AddsLineToString(sb, nameBeerDrunk);
            AddsLineToString(sb, nameAccBalanceBank);

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static string[] ReturnUserInputAsArray()
        {
            var userInput = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToArray();

            return userInput;
        }

        private static Threeuple<string, string, string> ReturnsFullnameAddressTown(string[] userInput)
        {


            var fullname = userInput[0] + " " + userInput[1];
            var address = userInput[2];
            var town = userInput.Count() > 4 ? userInput[3] + " " + userInput[4] : userInput[3];

            var nameAddressTown = new Threeuple<string, string, string>(fullname, address, town);

            return nameAddressTown;
        }

        private static Threeuple<string, int, string> ReturnsFirstNameLittersBeerDrunkOrNot(string[] userInput)
        {
            var firstName = userInput[0];
            var beerLitters = int.Parse(userInput[1]);
            var drunkOrNot = userInput[2].ToLower() == "drunk" ? true : false;

            var firstNameBeerLittersDrunkOrNot = new Threeuple<string, int, string>(firstName, beerLitters, drunkOrNot.ToString());

            return firstNameBeerLittersDrunkOrNot;
        }

        private static Threeuple<string, string, string> ReturnsNameAccountBalanceBankName(string[] userInput)
        {
            var firstName = userInput[0];
            var accountBalance = Decimal.Parse(userInput[1]).ToString("F1");
            var bankName = userInput[2];

            var firstNameAccountBalanceBankName = new Threeuple<string, string, string>(firstName, accountBalance, bankName);

            return firstNameAccountBalanceBankName;
        }

        private static void AddsLineToString<T1, T2, T3>(StringBuilder sb, Threeuple<T1, T2, T3> threeuple)
        {
            sb.AppendLine($"{threeuple.FirstElement} -> {threeuple.SecondElement} -> {threeuple.ThirdElement}");
        }
    }
}
