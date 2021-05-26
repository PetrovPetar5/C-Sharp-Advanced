namespace GenericBoxOfString
{
    using System;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            var inputCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputCount; i++)
            {
                var currentBoxValue = new Box<string>(Console.ReadLine());
                sb.AppendLine(currentBoxValue.ToString());
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
