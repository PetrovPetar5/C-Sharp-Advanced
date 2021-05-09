namespace CopyBinaryFile
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new FileStream(@"C:\Users\Lenovo\Downloads\front.jpg", FileMode.Open, FileAccess.Read))
            using (var writer = new FileStream($"{Directory.GetCurrentDirectory()}Result.jpg", FileMode.OpenOrCreate,
                FileAccess.Write))
            {
                var buffer = new byte[4024];
                var bytesRead = 0;
                var bufferUsed = 0;
                while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    writer.Write(buffer, 0, bytesRead);
                    bufferUsed++;
                }
                Console.WriteLine(bufferUsed);
            }
        }
    }
}
