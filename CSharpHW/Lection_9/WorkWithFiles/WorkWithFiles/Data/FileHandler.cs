using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkWithFiles.Data
{
    public struct FileHandler
    {
        public long FileSize { get; private set; }

        public string FileName { get; private set; }

        public string FilePath { get; private set; }

        public FileAccessEnum AuthorizedOperationWithFile { get; private set; }

        private FileHandler(long fileSize, string fileName, string filePath, FileAccessEnum fileAccessMode)
            : this()
        {
            this.FileSize = fileSize;
            this.FileName = fileName;
            this.FilePath = filePath;
            this.AuthorizedOperationWithFile = fileAccessMode;
        }

        public static FileHandler OpenForRead(string pathToFile)
        {
            try
            {
                FileHandler newFileHandler;

                using (var fs = new FileStream(pathToFile, FileMode.Open, FileAccess.Read))
                {
                    newFileHandler = new FileHandler(fs.Length, FindOutFileName(pathToFile), pathToFile, FileAccessEnum.Read);

                    using (var readFromFile = new StreamReader(fs, Encoding.UTF8, true, 128))
                    {
                        Console.WriteLine("Data from file ", newFileHandler.FileName);
                        string LineFromFile;
                        while ((LineFromFile = readFromFile.ReadLine()) != null)
                        {
                            Console.WriteLine(LineFromFile);
                        }
                    }
                }
                return newFileHandler;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("You entered invalid path to file! Please try again");
                return new FileHandler();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
                return new FileHandler();
            }
        }
        public static FileHandler OpenForWrite(string pathToFile)
        {
            try
            {
                FileHandler newFileHandler;

                using (var fs = new FileStream(pathToFile, FileMode.Open, FileAccess.Write))
                {
                    newFileHandler = new FileHandler(new FileInfo(pathToFile).Length, FindOutFileName(pathToFile), pathToFile, FileAccessEnum.Write);

                    using (var writeToFile = new StreamWriter(fs, Encoding.UTF8, 128, false))
                    {
                        Console.WriteLine("\nNow you can write down something to the file, after you finish write, please press enter");
                        writeToFile.WriteLine(Console.ReadLine());
                    }
                }

                return newFileHandler;

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("You entered invalid path to file! Please try again");
                return new FileHandler();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
                return new FileHandler();
            }
        }

        public static FileHandler OpenFile(string pathToFile, FileAccessEnum authorizedOperation)
        {
            if (((FileAccessEnum.Read | FileAccessEnum.Write) & authorizedOperation) == (FileAccessEnum.Read | FileAccessEnum.Write))
            {
                try
                {
                    FileHandler newFileHandler;

                    using (var fs = new FileStream(pathToFile, FileMode.Open, FileAccess.ReadWrite))
                    {

                        newFileHandler = new FileHandler(fs.Length, FindOutFileName(pathToFile), pathToFile, authorizedOperation);

                        using (var writeToFile = new StreamWriter(fs, Encoding.UTF8, 128, true))
                        {
                            Console.WriteLine("\nNow you can write down something to the file, after you finish write, please press enter");
                            writeToFile.WriteLine(Console.ReadLine());
                        }

                        fs.Position = 0;

                        using (var readFromFile = new StreamReader(fs, Encoding.UTF8, true, 128)) 
                        {
                            Console.WriteLine("\nData from file {0} after user changed them", newFileHandler.FileName);
                            Console.WriteLine(readFromFile.ReadToEnd());

                        }
                    }
                    return newFileHandler;
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("You entered invalid path to file! Please try again");
                    return new FileHandler();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong!");
                    return new FileHandler();
                }
            }
            else
            {
                if (FileAccessEnum.Read.HasFlag(authorizedOperation))
                {
                    return OpenForRead(pathToFile);
                }
                else
                {
                    return OpenForWrite(pathToFile);
                }
            }
        }

        private static string FindOutFileName(string pathToFile)
        {
            // Convert path to file to char array, then it's reversing.
            var charArray = pathToFile.ToCharArray();
            Array.Reverse(charArray);


            // Find out index of first occurrence of backslash and using it to substring path to file from the beginning of the index.
            int firstOccurrenceOfBackslash = new string(charArray).IndexOf(@"\");
            string fileName = pathToFile.Substring(pathToFile.Length - firstOccurrenceOfBackslash);

            return fileName;
        }
    }
}
