using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopIsActive = true;

            LibraryBase library = new LibraryBase();

            do
            {
                Console.WriteLine("Hello, do you want authorize? Press 1 if Yes or 2 if No");
                
                switch(Console.ReadKey().KeyChar)
                {
                    case '1':
                        {
                            Console.WriteLine("Please, enter your login, then press enter and enter your password");
                            library.IsVerifiedUser(Console.ReadLine(), Console.ReadLine());
                            break;
                        }
                    case '2':
                        {
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("You pressed wrong button, please try again");
                            break;
                        }
                }
            }
            while (loopIsActive);

        }
    }
}
