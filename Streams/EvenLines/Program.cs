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


            using (var outputWriter = new StreamWriter($@"{Directory.GetCurrentDirectory()}\Output.txt", false))
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

                        outputWriter.WriteLine(String.Join(" ", curLine.ToString().Split().Reverse().ToArray()));
                    }
                    else
                    {
                        inputReader.ReadLine();
                    }

                    counter++;
                }
            }
        }
    }
}