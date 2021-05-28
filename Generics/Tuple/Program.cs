using System;
using System.Linq;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nameAddress = Console.ReadLine()
                .Split().ToArray();
            var fullName = $"{nameAddress[0]} {nameAddress[1]}";
            var address = nameAddress[2];

            var beerInfo = Console.ReadLine()
                .Split().ToArray();
            var name = beerInfo[0];
            var beerAmount = int.Parse(beerInfo[1]);

            var numbersInfo = Console.ReadLine()
               .Split().ToArray();
            var someIntNum = int.Parse(numbersInfo[0]);
            var someDoubleNum = double.Parse(numbersInfo[1]);

            var nameAndAddress = new Tuplee<string, string>(fullName, address);
            var beerLitersDrank = new Tuplee<string, int>(name, beerAmount);
            var regularIntAndDoubleNumbers = new Tuplee<int, double>(someIntNum, someDoubleNum);

            Console.WriteLine(nameAndAddress);
            Console.WriteLine(beerLitersDrank);
            Console.WriteLine(regularIntAndDoubleNumbers);
        }
    }
}
