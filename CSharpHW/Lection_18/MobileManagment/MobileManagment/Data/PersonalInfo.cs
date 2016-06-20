using System;


namespace MobileManagment.Data
{
    public class PersonalInfo
    {
        public string Name { get; private set; }

        public int MobileNumber { get; private set; }

        public PersonalInfo(string name, int mobileNumber)
        {
            this.Name = name;
            this.MobileNumber = mobileNumber;
        }
    }
}
