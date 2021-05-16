namespace TriFunction
{
    using System;
    using System.Linq;
    public class Program
    {
        static void Main(string[] args)
        {
            var targetFigure = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();
            Func<string, int, bool> greaterCharsSum = (x, y) =>
              {
                  var wordCharsSum = 0;
                  foreach (var @char in x)
                  {
                      wordCharsSum += @char;
                  }

                  var isGreater = wordCharsSum >= y ? true : false;

                  return isGreater;
              };

            var firstNameGreater = names.Where(x => greaterCharsSum(x, targetFigure)).Take(1).ToList() ;
            Console.WriteLine(firstNameGreater[0]);
        }
    }
}
