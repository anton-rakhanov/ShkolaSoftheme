using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesValidationAndUsers.Data;
using InterfacesValidationAndUsers.Data.Validators;
using InterfacesValidationAndUsers.Interfaces;
using InterfacesValidationAndUsers.Data.Enum;

namespace InterfacesValidationAndUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program shows how works validation with combination of interfaces and abstract class.");

            var someUser = new User();

            // DataBase that will be loaded in validators.
            string[,] currentDataBase = new string[3, 100];

            // Index of last record for proper search operation.
            int lastRecordIndex = 2;

            currentDataBase[0, 0] = "Bob";
            currentDataBase[0, 1] = "Marry";
            currentDataBase[0, 2] = "Sam";
            currentDataBase[1, 0] = "Boby@live.com";
            currentDataBase[1, 1] = "Marry-Jan@outlook.com";
            currentDataBase[1, 2] = "Samy@mail.ru";
            currentDataBase[2, 0] = "12345";
            currentDataBase[2, 1] = "00000";
            currentDataBase[2, 2] = "54321";

            MainValidator nameValidator = new NameValidator();
            nameValidator.DownloadUsersDataBase(currentDataBase, lastRecordIndex);

            MainValidator emailValidator = new EmailValidator();
            emailValidator.DownloadUsersDataBase(currentDataBase, lastRecordIndex);

            do
            {
                Console.WriteLine("If you want to exit, please enter your name, email and password as 'exit'");

                Console.WriteLine("\nPlease, enter your name: ");
                someUser.Name = Console.ReadLine();
                Console.WriteLine("\nNow, please enter your email: ");
                someUser.Email = Console.ReadLine();
                Console.WriteLine("\nAnd finally, please enter your password: ");
                someUser.Password = Console.ReadLine();

                if(someUser.Name == "exit" & someUser.Email == "exit" & someUser.Password == "exit")
                {
                    break;
                }

                Console.WriteLine("\nAvailable validators:" +
                                  "\nName validator - 1" +
                                  "\nEmail validator - 2");

                char pressedKey = Console.ReadKey().KeyChar;
                int parsedNumber;
                ValidatorType validatorType;

                if (int.TryParse(pressedKey.ToString(), out parsedNumber) && (parsedNumber < 1 || parsedNumber > 2))
                {
                    Console.Clear();
                    Console.WriteLine("You have pressed wrong button, please try again.");
                    continue;
                }

                validatorType = (ValidatorType)parsedNumber;

                switch(validatorType)
                {
                    case ValidatorType.NameValidator:
                        {
                            nameValidator.ValidateUser(someUser as IUser);

                            break;
                        }
                    case ValidatorType.EmailValidator:
                        {
                            emailValidator.ValidateUser(someUser as IUser);

                            break;
                        }
                }

            }
            while (true);

        }
    }
}
