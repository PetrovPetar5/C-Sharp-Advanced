namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var wordsCount = new Dictionary<string, int>();
            var curLine = String.Empty;
            using (var wordsInputReader = new StreamReader($@"{Directory.GetCurrentDirectory()}\words.txt"))
            {
                while (!wordsInputReader.EndOfStream)
                {
                    curLine = wordsInputReader.ReadLine();
                    var words = ReturnsPunctuationFreeArray(curLine);

                    foreach (var word in words)
                    {
                        if (wordsCount.ContainsKey(word))
                        {
                            continue;
                        }

                        wordsCount[word] = 0;
                    }
                }
            }

            using (var textInputReader = new StreamReader($@"{Directory.GetCurrentDirectory()}\text.txt"))
            {
                while (!textInputReader.EndOfStream)
                {
                    curLine = textInputReader.ReadLine();
                    var words = ReturnsPunctuationFreeArray(curLine);

                    foreach (var word in words)
                    {
                        if (!wordsCount.ContainsKey(word))
                        {
                            continue;
                        }

                        wordsCount[word]++;
                    }
                }
            }

            wordsCount = wordsCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            WriteInTheOutputFile(wordsCount);
        }

        private static string[] ReturnsPunctuationFreeArray(string curLine)
        {
            var punctuation = curLine.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = curLine.Split().Select(x => x.Trim(punctuation)).ToArray();
            return words;
        }

        private static void WriteInTheOutputFile(Dictionary<string, int> wordsCount)
        {
            using (var writer = new StreamWriter($@"{Directory.GetCurrentDirectory()}\output.txt", false))
            {
                foreach (var word in wordsCount)
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
