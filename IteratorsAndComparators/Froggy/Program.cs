using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Lake curLake = new Lake(inputArgs);
            Console.WriteLine(String.Join(", ", curLake));
        }
    }
}
