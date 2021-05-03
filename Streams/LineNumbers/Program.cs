namespace LineNumbers
{
    using System.IO;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            using (var fs = new FileStream($@"{Directory.GetCurrentDirectory()}\Input.txt", FileMode.Open, FileAccess.Read))
            {
                var counter = 1;

                using (var reader = new StreamReader(fs, Encoding.UTF8))
                {
                    using (var writer = new StreamWriter($@"{Directory.GetCurrentDirectory()}\Output.txt"))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            writer.WriteLine($"{counter}. {line}");
                            counter++;
                        }
                    }
                }
            }
        }
    }
}
