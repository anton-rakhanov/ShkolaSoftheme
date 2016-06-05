using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDemonstration.Data
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User()
        {

        }

        public User(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
