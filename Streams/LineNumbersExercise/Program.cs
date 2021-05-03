namespace LineNumbersExercise
{
    using System;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllText($@"{Directory.GetCurrentDirectory()}\text.txt");
            var inputLines = file.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            using (var outputWriter = new StreamWriter($@"{Directory.GetCurrentDirectory()}\output.txt", false))
            {
                var lineCounter = 1;
                foreach (var line in inputLines)
                {
                    var lettersCount = line.Count(char.IsLetter);
                    var punctoationSignsCount = line.Count(char.IsPunctuation);
                    outputWriter.WriteLine($"Line {lineCounter}: -{line} ({lettersCount})({punctoationSignsCount})");
                    lineCounter++;
                }
            }
        }
    }
}
