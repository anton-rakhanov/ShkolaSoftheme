using System;
using System.Collections.Generic;

namespace MobileManagment.Data.Mobile
{
    public class MobileOperator
    {

        public delegate void CallFrom(int from);

        
        public delegate void SMSFrom(int from, string text);

        
        public static event CallFrom IncomingCall;


        public static event SMSFrom IncomingMessage;
        
            
        public static List<MobileAccount> RegisteredMobileAccounts { get; private set; }


        static MobileOperator()
        {
            RegisteredMobileAccounts = new List<MobileAccount>();
        }

        public static void RouteCall(int from, int to)
        {
            foreach(var contact in RegisteredMobileAccounts)
            {
                if(contact.AccountUserInfo.MobileNumber.Equals(to))
                {
                    IncomingCall += contact.IncomingCall;
                    if(!IsIncomingCallNull())
                    {
                        IncomingCall(from);
                    }
                    IncomingCall -= contact.IncomingCall;
                    return;
                }
            }


            Console.WriteLine("Sorry, but mobile account with that number doesn't exist.");
        
        }

        public static void RouteSMSMessage(int from, int to, string text)
        {
            foreach (var contact in RegisteredMobileAccounts)
            {
                if (contact.AccountUserInfo.MobileNumber.Equals(to))
                {
                    IncomingMessage += contact.IncomingMessage;
                    if (!IsIncomingMessageNull())
                    {
                        IncomingMessage(from, text);
                    }
                    IncomingMessage -= contact.IncomingMessage;
                    return;
                }
            }

            Console.WriteLine("Sorry, but mobile account with that number doesn't exist.");

        }

        public static void RegisterMobileAccount(MobileAccount newAccount)
        {
            RegisteredMobileAccounts.Add(newAccount);
        }

        private static bool IsIncomingCallNull()
        {
            if(IncomingCall == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private static bool IsIncomingMessageNull()
        {
            if (IncomingMessage == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
