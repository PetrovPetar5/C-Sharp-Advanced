namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var dirFiles = Directory.GetFiles($@"{Directory.GetCurrentDirectory()}");
            var extensions = new Dictionary<string, HashSet<FileInfo>>();
            foreach (var @path in dirFiles)
            {

                var fileInfo = new FileInfo(@path);
                var curExtension = fileInfo.Extension;
                if (!extensions.ContainsKey(curExtension))
                {
                    extensions[curExtension] = new HashSet<FileInfo>();
                }

                extensions[curExtension].Add(fileInfo);
            }

            extensions = extensions.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            using (var writer = new StreamWriter($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}report.txt"))
            {
                foreach (var extension in extensions)
                {
                    writer.WriteLine($"{extension.Key}");

                    foreach (var @fileInfo in extension.Value)
                    {
                        writer.WriteLine($"--{@fileInfo.Name} - {@fileInfo.Length * 0.001:F3}kb");
                    }
                }
            }
        }
    }
}
