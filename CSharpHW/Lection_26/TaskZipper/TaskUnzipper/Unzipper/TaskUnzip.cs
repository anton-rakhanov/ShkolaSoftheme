using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace TaskUnzipper.Unzipper
{
    public class TaskUnzip
    {
        public void UnZipAllFromDir(object pathToDir)
        {

            string fullPath = pathToDir as string;


            if (!Directory.Exists(fullPath))
            {
                throw new ArgumentException();
            }


            string zipPathPattern = @"{0}\ResultOfUnzipDir\{1}";


            var childDirs = Directory.GetDirectories(fullPath);
            var filesInDir = Directory.GetFiles(fullPath);


            if (childDirs.Length != 0)
            {

                Parallel.ForEach(childDirs, cdir => UnZipAllFromDir(cdir));

            }


            if (filesInDir.Length != 0)
            {

                foreach (var file in filesInDir)
                {

                    lock (this)
                    {

                        if (!file.Contains(".zip"))
                        {
                            continue;
                        }


                        string fileName = file.Substring(file.LastIndexOf(@"\") + 1);
                        fileName = fileName.Substring(0, fileName.Length - 4);
                        var unzipPath = string.Format(zipPathPattern, Directory.GetCurrentDirectory(), fileName);


                        using (FileStream sourceStream = new FileStream(file, FileMode.OpenOrCreate))
                        {

                            using (FileStream targetStream = File.Create(unzipPath))
                            {

                                using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                                {
                                    decompressionStream.CopyTo(targetStream);
                                    Console.WriteLine("Восстановление файла {0} завершено.", file);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
