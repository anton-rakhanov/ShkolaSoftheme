using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Librarium.Data;

namespace Librarium.Data.LibraryAuthorizationModule
{
    [Serializable]
    public class LibraryAuthorizator
    {

        public List<LibraryUser> RegisteredSubscribers { get; set; }


        public LibraryAuthorizator()
        {
            RegisteredSubscribers = new List<LibraryUser>();
        }


        public LibraryAuthorizator(List<LibraryUser> registeredSubscribers)
        {
            this.RegisteredSubscribers = registeredSubscribers;
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
                RegisteredSubscribers.Add(newUser);
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
                RegisteredSubscribers.Add(newUser);
            }
        }


        public bool IsAuthorized(string login, string password)
        {

            foreach (var subscriber in RegisteredSubscribers)
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
