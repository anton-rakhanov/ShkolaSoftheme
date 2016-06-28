using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadZipper.Zipper
{
    public class ThreadZip
    {
        public void ZipAllInDir(object pathToDir)
        {

            string fullPath = pathToDir as string;


            if (!Directory.Exists(fullPath))
            {
                throw new ArgumentException();
            }


            string zipPathPattern = @"{0}\ResultZIpDir\{1}.zip";


            var childDirs = Directory.GetDirectories(fullPath);
            var filesInDir = Directory.GetFiles(fullPath);


            if (childDirs.Length != 0)
            {

                foreach (var dir in childDirs)
                {
                    var pts = new ParameterizedThreadStart(ZipAllInDir);
                    var thread = new Thread(pts);
                    thread.Start(dir);
                }

            }


            if (filesInDir.Length != 0)
            {

                foreach (var file in filesInDir)
                {

                    lock (this)
                    {

                        if (file.Contains(".zip"))
                        {
                            continue;
                        }


                        string fileName = file.Substring(file.LastIndexOf(@"\") + 1);
                        var zipPath = string.Format(zipPathPattern, Directory.GetCurrentDirectory(), fileName);


                        using (FileStream sourceStream = new FileStream(file, FileMode.OpenOrCreate))
                        {

                            using (FileStream targetStream = File.Create(zipPath))
                            {

                                using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                                {
                                    sourceStream.CopyTo(compressionStream);
                                    Console.WriteLine("Сжатие файла {0} завершено.", file);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
