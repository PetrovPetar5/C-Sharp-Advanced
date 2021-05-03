namespace WordCountExercise
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var wordsFrequency = new Dictionary<string, int>();
            using (var wordsInputReader = new StreamReader($@"{Directory.GetCurrentDirectory()}\words.txt"))
            {
                while (!wordsInputReader.EndOfStream)
                {
                    var wordToAdd = wordsInputReader.ReadLine().ToLower();
                    if (!wordsFrequency.ContainsKey(wordToAdd))
                    {
                        wordsFrequency[wordToAdd] = 0;
                    }
                }
            }

            using (var inputTextReader = new StreamReader($@"{Directory.GetCurrentDirectory()}\text.txt"))
            {
                while (!inputTextReader.EndOfStream)
                {
                    var curLine = inputTextReader.ReadLine();
                    var curLinePunctuationSigns = curLine.Where(char.IsPunctuation).Distinct().ToArray();
                    var wordsOnly = curLine.Split().Select(x => x.Trim(curLinePunctuationSigns)).Select(x => x.ToLower()).ToArray();
                    foreach (var word in wordsOnly)
                    {
                        if (!wordsFrequency.ContainsKey(word))
                        {
                            continue;
                        }

                        wordsFrequency[word]++;
                    }
                }
            }

            wordsFrequency = wordsFrequency.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            using (var outputWriter = new StreamWriter($@"{Directory.GetCurrentDirectory()}\actualResult.txt"))
            {
                foreach (var word in wordsFrequency)
                {
                    outputWriter.WriteLine($"{word.Key} - {word.Value}");
                }
            }

            var firstFile = File.ReadAllText($@"{Directory.GetCurrentDirectory()}\actualResult.txt");
            var secondFile = File.ReadAllText($@"{Directory.GetCurrentDirectory()}\expectedResult.txt");
            var equality = File.Equals(firstFile, secondFile);
        }
    }
}
