using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Calc
{
    class Calculator
    {
        private double Sum(double value1, double value2)
        {
            return value1 + value2;
        }

        private double Substraction(double value1, double value2)
        {
            return value1 - value2;
        }

        private double Multiplication(double value1, double value2)
        {
            return value1 * value2;
        }

        private double Divide(double value1, double value2)
        {
            try
            {
                if(value2 == 0)
                {
                    throw new DivideByZeroException();
                }
                return value1 / value2;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("\nYou are trying to divide by zero");
                return -1.0;
            }
        }

        public void ExecuteCalculator()
        {

            double enteredValue1 = 0;
            double enteredValue2 = 0;
            double result = 0;

            bool loopIsActive = true;

            Console.WriteLine("Hello, this is a calculator with basic operations like: Sums, Substraction, Multiplication, Divide.");

            do
            {
                Console.WriteLine("Please, type a first number and press enter, then type second number and press enter again.");

                if(!double.TryParse(Console.ReadLine(), out enteredValue1) || !double.TryParse(Console.ReadLine(), out enteredValue2))
                {
                    Console.WriteLine("You entered unexceptable data! Try again.");
                    continue;
                }
                break;
            }
            while (true);

            do
            {
                Console.WriteLine("\nYou entered {0} as first number and {1} as second number", enteredValue1, enteredValue2);
                Console.WriteLine("This calc can do next basic operations: ");
                Console.WriteLine("Sums: +");
                Console.WriteLine("Substract: -");
                Console.WriteLine("Multiply: *");
                Console.WriteLine("Divide: /");
                Console.WriteLine("\nTo choose operation please type proper symbol");

                var chosenSymbol = Console.ReadKey().KeyChar;

                switch (chosenSymbol)
                {
                    case '+':
                        {
                            result = Sum(enteredValue1, enteredValue2);
                            loopIsActive = false;
                            break;
                        }
                    case '-':
                        {
                            result = Substraction(enteredValue1, enteredValue2);
                            loopIsActive = false;
                            break;
                        }
                    case '*':
                        {
                            result = Multiplication(enteredValue1, enteredValue1);
                            loopIsActive = false;
                            break;
                        }
                    case '/':
                        {
                            result = Divide(enteredValue1, enteredValue2);
                            loopIsActive = false;
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("\nYou typed wrong symbol, please try again");
                            continue;
                        }
                }

                Console.WriteLine("\nA result of operation {0} is {1:0.##}", chosenSymbol, result);
                Console.WriteLine("\nTo finish working with program press any key.");
                Console.ReadKey();
            }
            while(loopIsActive);
        }
    }
}
