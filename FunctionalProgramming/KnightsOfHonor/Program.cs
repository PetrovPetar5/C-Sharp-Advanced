namespace KnightsOfHonor
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            Action<String[]> addsSirToName = names =>
            {
                Console.WriteLine(String.Join(Environment.NewLine, names.Select(x => "Sir " + x).ToArray()));
            };

            addsSirToName(names);
        }
    }
}
