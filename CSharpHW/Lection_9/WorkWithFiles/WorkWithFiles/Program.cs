using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithFiles.Data;
using System.IO;

namespace WorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program demonstate work with enums_flags!");
            Console.WriteLine("Please, enter full path to file\n");

            bool loopIsActive = true;
            string pathToFile = Console.ReadLine();

            do
            {
                if (!File.Exists(pathToFile))
                {
                    Console.Clear();
                    Console.WriteLine("You entered wrong path to file, or this file doesn't exist! Please, try again.\n");
                    Console.WriteLine("Please, enter full path to file\n");

                    pathToFile = Console.ReadLine();

                    continue;
                }

                Console.WriteLine("\nAvailable operations with file: \n" +
                                  "Open for read - 1\n" +
                                  "Open for write - 2\n" +
                                  "Open file(in WriteRead mode) - 3\n" +
                                  "Exit - 0");
                Console.WriteLine("\nTo choose operation, please press proper button");


                char pressedKey = Console.ReadKey().KeyChar;
                int parsedNumber;
                FileAccessEnum operation;

                if (int.TryParse(pressedKey.ToString(), out parsedNumber) && (parsedNumber < 0 || parsedNumber > 3))
                {
                    Console.Clear();
                    Console.WriteLine("You have pressed wrong button, please try again.");
                    continue;
                }

                operation = (FileAccessEnum)parsedNumber;

                switch (operation)
                {
                    case FileAccessEnum.Read:
                        {
                            Console.WriteLine("\nYou have choosed read operation.\n");

                            FileHandler newFileHandler = FileHandler.OpenForRead(pathToFile);

                            Console.WriteLine("\nInfo about the file: "+
                                              "\nFile name: {0}"+
                                              "\nFile size: {1}"+
                                              "\nFull path to file: {2}"+
                                              "\nOperation with file: {3}",
                                              newFileHandler.FileName, 
                                              newFileHandler.FileSize,
                                              newFileHandler.FilePath,
                                              newFileHandler.AuthorizedOperationWithFile);

                            loopIsActive = false;
                            Console.WriteLine("\nThank you for your time, press any button to exit, good luck!");
                            Console.ReadKey();
                            break;
                        }
                    case FileAccessEnum.Write:
                        {
                            Console.WriteLine("\nYou have choosed write operation.\n");

                            FileHandler newFileHandler = FileHandler.OpenForWrite(pathToFile);

                            Console.WriteLine("\nInfo about the file: \n"+
                                              "\nFile name: {0}"+
                                              "\nFile size: {1}"+
                                              "\nFull path to file: {2}"+
                                              "\nOperation with file: {3}",
                                              newFileHandler.FileName,
                                              newFileHandler.FileSize,
                                              newFileHandler.FilePath,
                                              newFileHandler.AuthorizedOperationWithFile.ToString());

                            loopIsActive = false;
                            Console.WriteLine("\nThank you for your time, press any button to exit, good luck!");
                            Console.ReadKey();
                            break;
                        }
                    case FileAccessEnum.Read | FileAccessEnum.Write:
                        {
                            Console.WriteLine("\nYou have choosed read/write operation.\n");

                            FileHandler newFileHandler = FileHandler.OpenFile(pathToFile, operation);

                            Console.WriteLine("\nInfo about the file: \n"+
                                              "\nFile name: {0}"+
                                              "\nFile size: {1}"+
                                              "\nFull path to file: {2}"+
                                              "\nOperation with file: {3}",
                                              newFileHandler.FileName,
                                              newFileHandler.FileSize,
                                              newFileHandler.FilePath,
                                              newFileHandler.AuthorizedOperationWithFile.ToString());

                            loopIsActive = false;
                            Console.WriteLine("\nThank you for your time, press any button to exit, good luck!");
                            Console.ReadKey();
                            break;
                        }
                    case FileAccessEnum.None:
                        {
                            loopIsActive = false;
                            Console.WriteLine("\nThank you for your time, press any button to exit, good luck!");
                            Console.ReadKey();
                            break;
                        }
                }
            }
            while (loopIsActive);
        }
    }
}
