namespace Froggy
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var stoneNumbers = Console.ReadLine()
                                        .Split(", ")
                                        .Select(int.Parse)
                                        .ToArray();
            var lake = new Lake(stoneNumbers);

            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
