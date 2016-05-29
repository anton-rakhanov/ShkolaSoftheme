using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DisplayFigure.Algorith;

namespace DisplayFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLoopActive = true;

            do
            {

                Console.WriteLine("Hello, this programm can build 3 different type of figures: Triangle, Square and Rhombus!");
                Console.WriteLine("To choose figure that will be built press:");
                Console.WriteLine("1 : Triangle");
                Console.WriteLine("2 : Square");
                Console.WriteLine("3 : Rhombus");
                Console.WriteLine("Press 0 to exit.");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        {
                            Console.WriteLine("\nYou have choosed Triangle! Please input a size of figure\n");

                            int enteredSize;

                            if (int.TryParse(Console.ReadLine(), out enteredSize) && ShapeBuilder.CheckInput(enteredSize))
                            {
                                ShapeBuilder.BuildTriangle(enteredSize);
                                Console.WriteLine("\nPress any key to exit");
                                Console.ReadKey();
                                isLoopActive = false;
                            }
                            else
                            {
                                Console.WriteLine("\nYou entered invalid data! Please try again.");
                                break;
                            }
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("\nYou have choosed Square! Please input a size of figure\n");

                            int enteredSize;

                            if (int.TryParse(Console.ReadLine(), out enteredSize) && ShapeBuilder.CheckInput(enteredSize))
                            {
                                ShapeBuilder.BuildSquare(enteredSize);
                                Console.WriteLine("\nPress any key to exit");
                                Console.ReadKey();
                                isLoopActive = false;
                            }
                            else
                            {
                                Console.WriteLine("\nYou entered invalid data! Please try again.");
                                break;
                            }
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine("\nYou have choosed Rhombus! Please input a size of figure\n");

                            int enteredSize;

                            if (int.TryParse(Console.ReadLine(), out enteredSize) && ShapeBuilder.CheckInput(enteredSize))
                            {
                                ShapeBuilder.BuildRhombus(enteredSize);
                                Console.WriteLine("\nPress any key to exit");
                                Console.ReadKey();
                                isLoopActive = false;
                            }
                            else
                            {
                                Console.WriteLine("\nYou entered invalid data! Please try again.");
                                break;
                            }
                            break;
                        }
                    case '0':
                        {
                            isLoopActive = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nYou entered invalid data! Please try again.");
                            break;
                        }
                }
            }
            while (isLoopActive);
        }
    }
}
