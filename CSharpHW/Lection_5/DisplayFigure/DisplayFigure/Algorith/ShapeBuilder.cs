using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayFigure.Algorith
{
    public class ShapeBuilder
    {
        public static void BuildTriangle(int size)
        {
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write("+ ");
                }
                Console.WriteLine();
            }
        }

        public static void BuildSquare(int size)
        {
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("+ ");
                }
                Console.WriteLine();
            }
        }

        public static void BuildRhombus(int size)
        {
            int outerSpaceCounter = (size - 2) / 2;
            int innerSpaceCounter = outerSpaceCounter;

            if(size % 2 == 0)
            {
                for(int i = 1; i < size; i++)
                {
                    for(int j = 1; j < size + 1; j++)
                    {
                        if (innerSpaceCounter > 0)
                        {
                            innerSpaceCounter--;
                            Console.Write("  ");
                        }
                        else
                        {
                            if (j > (size / 2) + 1)
                            {
                                break;
                            }
                            Console.Write("+ ");
                        }
                    }
                    if(i < (size / 2))
                    {
                        outerSpaceCounter--;
                        innerSpaceCounter = outerSpaceCounter;
                    }
                    else
                    {
                        outerSpaceCounter++;
                        innerSpaceCounter = outerSpaceCounter;
                    }
                    Console.WriteLine();
                }
            }
        }

        public static bool CheckInput(int size)
        {
            if(size <= 0 || size == 1)
            {
                Console.WriteLine("You have entered invalid data! Please try again.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
