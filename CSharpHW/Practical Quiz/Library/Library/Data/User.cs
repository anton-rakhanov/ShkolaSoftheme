using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        private string _login;

        public string Login
        {
            get { return _login; }
        }

        public string Password { get; set; }

        public User(string firstName, string lastName, string login, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            _login = login;
            Password = password;
        }
    }
}
