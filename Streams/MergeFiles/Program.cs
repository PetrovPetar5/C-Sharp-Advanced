namespace MergeFiles
{
    using System.IO;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            using (var outputWriter = new StreamWriter($@"{Directory.GetCurrentDirectory()}\Output.txt", false))
            {
                using (var fileOneReader = new StreamReader($@"{Directory.GetCurrentDirectory()}\FileOne.txt", Encoding.UTF8))
                using (var fileTwoReader = new StreamReader($@"{Directory.GetCurrentDirectory()}\FileTwo.txt", Encoding.UTF8))
                {
                    while (!fileOneReader.EndOfStream)
                    {
                        var firstFileLine = fileOneReader.ReadLine();
                        var secondFileLine = fileTwoReader.ReadLine();
                        outputWriter.WriteLine(firstFileLine);
                        outputWriter.WriteLine(secondFileLine);
                    }
                }
            }
        }
    }
}
