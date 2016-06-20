using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            var newUser = new LibraryUser(firstName, lastName, login, password);

            var results = new List<ValidationResult>();
            var context = new ValidationContext(newUser);

            if(!Validator.TryValidateObject(newUser, context, results, true))
            {
                foreach(var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                _registeredSubscribers.Add(newUser);
            }
        }


        public void Registration(LibraryUser newUser)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(newUser);

            if (!Validator.TryValidateObject(newUser, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                _registeredSubscribers.Add(newUser);
            }
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
