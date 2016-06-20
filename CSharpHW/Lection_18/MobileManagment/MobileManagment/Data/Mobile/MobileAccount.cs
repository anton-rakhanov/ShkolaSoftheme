using System;
using System.Collections.Generic;
using MobileManagment.Data;

namespace MobileManagment.Data.Mobile
{

    public class MobileAccount
    {

        private List<PersonalInfo> _adressBook;


        public PersonalInfo AccountUserInfo { get; private set; }


        public MobileAccount(PersonalInfo accountUserInfo)
        {
            this.AccountUserInfo = accountUserInfo;
        }


        public MobileAccount(PersonalInfo accountUserInfo, List<PersonalInfo> adressBook)
        {
            this._adressBook = adressBook;
            this.AccountUserInfo = accountUserInfo;
        }


        public void IncomingCall(int callingNumber)
        {
            foreach (var contact in _adressBook)
            {

                if (contact.MobileNumber.Equals(callingNumber))
                {
                    Console.WriteLine("{0} is calling to you! You're {1} and your number is {2}", contact.Name, AccountUserInfo.Name, AccountUserInfo.MobileNumber);
                    return;
                }

            }

            Console.WriteLine("Call from number: {0}, You're {1} and your number is {2}", callingNumber, AccountUserInfo.Name, AccountUserInfo.MobileNumber);
        }


        public void IncomingMessage(int sendingNumber, string text)
        {
            foreach (var contact in _adressBook)
            {

                if (contact.MobileNumber.Equals(sendingNumber))
                {
                    Console.WriteLine("{0} have send you a message! You're {1} and your number is {2}", contact.Name, AccountUserInfo.Name, AccountUserInfo.MobileNumber);
                    Console.WriteLine("=========================================================================");
                    Console.WriteLine("Message: " + text);
                    return;
                }

            }

            Console.WriteLine("Message from number: {0}, You're {1} and your number is {2}", sendingNumber, AccountUserInfo.Name, AccountUserInfo.MobileNumber);

            Console.WriteLine("=========================================================================");
            Console.WriteLine("Message: " + text);
        }


        public void SendSMSTo(int phoneNumber, string text)
        {
            MobileOperator.RouteSMSMessage(this.AccountUserInfo.MobileNumber, phoneNumber, text);
        }

        public void CallTo(int phoneNumber)
        {
            MobileOperator.RouteCall(this.AccountUserInfo.MobileNumber, phoneNumber);
        }


        public void AttachAdressBook(List<PersonalInfo> adressBook)
        {
            this._adressBook = adressBook;
        }

    }
}
