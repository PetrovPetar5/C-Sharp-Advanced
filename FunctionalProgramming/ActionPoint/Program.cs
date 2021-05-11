namespace ActionPoint
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            Action<string[]> print = item => Console.WriteLine(String.Join(Environment.NewLine, item));
            print(names);
        }
    }
}
