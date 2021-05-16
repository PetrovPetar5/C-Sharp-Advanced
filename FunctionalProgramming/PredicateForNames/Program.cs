namespace PredicateForNames
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var lengthCryteria = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();
            Predicate<string> isLessOrEqual = name => name.Length <= lengthCryteria;
            names = names.Where(x => isLessOrEqual(x)).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}
