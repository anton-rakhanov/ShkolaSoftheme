using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesValidationAndUsers.Interfaces;

namespace InterfacesValidationAndUsers.Data
{
    public class User : IUser
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public string GetFullInfo()
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append(_name);
            strBuilder.Append("_");
            strBuilder.Append(_email);
            strBuilder.Append("_");
            strBuilder.Append(_password);
            return strBuilder.ToString();
        }

    }
}
