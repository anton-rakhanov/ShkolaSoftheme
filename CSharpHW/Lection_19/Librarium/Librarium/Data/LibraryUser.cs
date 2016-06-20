using System;

namespace Librarium.Data
{
    public class LibraryUser
    {
        public string FirstName { get; private set; }

        
        public string LastName { get; private set; }


        public string Login { get; private set; }


        public string Password { get; private set; }


        public LibraryUser(string firstName, string lastName, string login, string password)
        {

            if(firstName.Equals("") && firstName.Equals(null))
            {
                throw new ArgumentException("First name have value empty or a blank string");
            }
            else
            {
                this.FirstName = firstName;
            }

            if (lastName.Equals("") && lastName.Equals(null))
            {
                throw new ArgumentException("Last name have value empty or a blank string");
            }
            else
            {
                this.LastName = lastName;
            }

            if (login.Equals("") && login.Equals(null))
            {
                throw new ArgumentException("Login have value empty or a blank string");
            }
            else
            {
                this.Login = login;
            }

            if (firstName.Equals("") && firstName.Equals(null))
            {
                throw new ArgumentException("Password have value empty or a blank string");
            }
            else
            {
                this.FirstName = firstName;
            }

        }
    }
}
