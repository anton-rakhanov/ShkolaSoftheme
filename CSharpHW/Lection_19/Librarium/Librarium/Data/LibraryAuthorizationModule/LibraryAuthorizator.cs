using System;
using System.Collections.Generic;
using Librarium.Data;

namespace Librarium.Data.LibraryAuthorizationModule
{
    public class LibraryAuthorizator
    {

        private List<LibraryUser> _registeredSubscribers;


        public LibraryAuthorizator()
        {
            _registeredSubscribers = new List<LibraryUser>();
        }


        public LibraryAuthorizator(List<LibraryUser> registeredSubscribers)
        {
            this._registeredSubscribers = registeredSubscribers;
        }


        public void Registration(string firstName, string lastName, string login, string password)
        {
            _registeredSubscribers.Add(new LibraryUser(firstName, lastName, login, password));
        }


        public void Registration(LibraryUser newUser)
        {
            _registeredSubscribers.Add(newUser);
        }


        public bool IsAuthorized(string login, string password)
        {
            foreach (var subscriber in _registeredSubscribers)
            {
                if (subscriber.Login == login && subscriber.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
