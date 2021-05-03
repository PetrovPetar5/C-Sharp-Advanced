namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var charactersToReplace = new HashSet<char> { '-', ',', '.', '!', '?' };
            var replacement = '@';
            var evenLinesInput = new List<Stack<string>>();
            using (var inputReader = new StreamReader($@"{Directory.GetCurrentDirectory()}\text.txt"))
            {
                var counter = 0;
                while (!inputReader.EndOfStream)
                {
                    if (counter % 2 == 0)
                    {

                        var curLine = new StringBuilder(inputReader.ReadLine());
                        for (int i = 0; i < curLine.Length; i++)
                        {
                            if (charactersToReplace.Contains(curLine[i]))
                            {
                                curLine[i] = replacement;
                            }
                        }

                        evenLinesInput.Add(new Stack<string>(curLine.ToString().Split().ToArray()));

                    }
                    else
                    {
                        inputReader.ReadLine();
                    }

                    counter++;
                }
            }

            using (var outputWriter = new StreamWriter($@"{Directory.GetCurrentDirectory()}\Output.txt", false))
            {
                var sb = new StringBuilder();
                foreach (var stackWords in evenLinesInput)
                {

                    sb.AppendLine(String.Join(" ", stackWords));
                }

                outputWriter.Write(sb.ToString().TrimEnd());
            }
        }
    }
}
