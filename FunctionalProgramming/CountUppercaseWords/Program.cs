namespace CountUppercaseWords
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var punctuationSigns = input.Where(x => Char.IsPunctuation(x) || Char.IsWhiteSpace(x)).ToArray();
            var words = input.Split(punctuationSigns, StringSplitOptions.RemoveEmptyEntries);
            var upperCaseWords = words.Where(x => Char.IsUpper(x[0])).ToArray();
            var sb = new StringBuilder();
            foreach (var word in upperCaseWords)
            {
                sb.AppendLine(word);
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
