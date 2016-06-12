using System;
using Lotery.Data;

namespace Lotery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] winningComb = new int[6];

            for (int i = 0; i < winningComb.Length; i++)
            {
                winningComb[i] = rand.Next(1, 9);
            }

            var winTicket = new LotteryTicket(winningComb);

            int digitsIterator = 1;

            int indexIterator = 0;

            int parsedValue = 0;

            Console.WriteLine("Hello, this is lottery program, you will need enter 6 digits, from 1 to 9!");
            Console.WriteLine("==========================================================================================");

            var userTicket = new LotteryTicket();

            do
            {
                Console.Write("Please, enter {0} digit of the ticket: ", digitsIterator);
                if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out parsedValue) && (parsedValue >= 1 && parsedValue <= 9))
                {
                    Console.WriteLine();

                    userTicket[indexIterator++] = parsedValue;
                    digitsIterator++;

                    if(digitsIterator > 6)
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You entered wrong data, please try again!");
                }

            }
            while (true);

            Console.WriteLine("==========================================================================================");
            Console.WriteLine("Comparing digits! AND!!");


            for(int i = 0; i < 6; i++)
            {
                if(!winTicket[i].Equals(userTicket[i]))
                {
                    Console.WriteLine("Sorry, but you lose, better luck next time!");
                    break;
                }
            }

            Console.WriteLine("==========================================================================================");
            Console.WriteLine("Here is winning combination:");


            foreach(int digit in  winningComb)
            {
                Console.Write("{0}_", digit);
            }

            Console.WriteLine("\n==========================================================================================");
            Console.WriteLine("And here is yours: ");

            int[] userComb = userTicket.GetCombination();

            foreach (int digit in userComb)
            {
                Console.Write("{0}_", digit);
            }

            Console.WriteLine("\n==========================================================================================");
            Console.WriteLine("Thanks for your time, press any key to leave!");

            Console.ReadKey();

        }
    }
}
