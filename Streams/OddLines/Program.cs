namespace OddLines
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            using (var writer = new StreamWriter($@"{Directory.GetCurrentDirectory()}\output.txt", false))
            {
                using (var reader = new StreamReader($@"{Directory.GetCurrentDirectory()}\input.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                    }
                }
            }
        }
    }
}
