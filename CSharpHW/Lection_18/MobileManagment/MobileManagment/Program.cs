using System;
using System.Collections.Generic;
using MobileManagment.Data;
using MobileManagment.Data.Mobile;

namespace MobileManagment
{
    class Program
    {
        static void Main(string[] args)
        {

            var userOne = new MobileAccount(new PersonalInfo("Bob", 79786877));
            var userTwo = new MobileAccount(new PersonalInfo("Samon", 23125327));

            var unknownUser = new MobileAccount(new PersonalInfo("Shadow", 100000001));

            List<PersonalInfo> baseAdressBookOfUserOne = new List<PersonalInfo>();

            List<PersonalInfo> baseAdressBookOfUserTwo = new List<PersonalInfo>();


            Console.WriteLine("Hello this program simulates mobileOperator with help of delegates and events!");

            Console.WriteLine("We created 3 users, Bob, Samon and Shadow, Bob and Samon know each other, but none of them know about user Shadow");



            baseAdressBookOfUserOne.Add(userTwo.AccountUserInfo);
            userOne.AttachAdressBook(baseAdressBookOfUserOne);


            baseAdressBookOfUserTwo.Add(userOne.AccountUserInfo);
            userTwo.AttachAdressBook(baseAdressBookOfUserTwo);


            MobileOperator.RegisterMobileAccount(userOne);

            MobileOperator.RegisterMobileAccount(userTwo);

            MobileOperator.RegisterMobileAccount(unknownUser);

            Console.WriteLine("========================================================================================================================");

            Console.WriteLine("Now, Bob will call to his friend Samon");

            userOne.CallTo(23125327);

            Console.WriteLine("========================================================================================================================");

            Console.WriteLine("Now, Samon will send message to his frined Bob");

            userTwo.SendSMSTo(79786877, "Was happy to talk with you, pal. See ya!");

            Console.WriteLine("========================================================================================================================");

            Console.WriteLine("And now, user Shadow will send to Bob and Samon creepy message");

            unknownUser.SendSMSTo(79786877, "Bob.. I can see you..");
            unknownUser.SendSMSTo(23125327, "Samon.. I can hear you..");

            Console.WriteLine("Thaks for your time, press any key to exit");
            Console.ReadKey();

        }
    }
}
