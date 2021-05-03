namespace FolderSize
{
    using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSizeUsed = 0;
            var mainDirectoryFileNames = Directory.GetFiles(@"C:\Users\Lenovo\source\repos\Streams\FolderSize\TestFolderSize\TestFolder");
            var directories = Directory.GetDirectories(@"C:\Users\Lenovo\source\repos\Streams\FolderSize\TestFolderSize\TestFolder");
            foreach (var @file in mainDirectoryFileNames)
            {
                FileInfo info = new FileInfo(@file);
                totalSizeUsed += info.Length;
            }

            //if (directories.Length != 0)
            //{
            //    foreach (var @directory in directories)
            //    {
            //        var innerDirectoryFileNames = Directory.GetFiles(@directory);
            //        foreach (var @file in innerDirectoryFileNames)
            //        {
            //            FileInfo info = new FileInfo(@file);
            //            totalSizeUsed += info.Length / 1000000m;
            //        }
            //    }
            //}

            var outputWriter = new StreamWriter($@"{Directory.GetCurrentDirectory()}\Output.txt", false);
            outputWriter.WriteLine(totalSizeUsed / 1024m);
            outputWriter.Close();

        }
    }
}
