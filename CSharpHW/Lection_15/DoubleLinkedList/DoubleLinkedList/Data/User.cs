using System;

namespace DoubleLinkedList.Data
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }
    }
}
