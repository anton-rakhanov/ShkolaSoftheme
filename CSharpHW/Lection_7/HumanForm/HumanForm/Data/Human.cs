using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanForm.Data
{
    public class Human
    {
        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private readonly int _age;

        public int Age
        {
            get { return _age; }
        }

        public Human(DateTime birthDate)
        {
            this._birthDate = birthDate;
            this._firstName = "John";
            this._lastName = "Stoner";
            this._age = 21;
        }

        public Human(DateTime birthDate, string firstName)
        {
            this._birthDate = birthDate;
            this._firstName = firstName;
            this._lastName = "Stoner";
            this._age = 21;
        }

        public Human(DateTime birthDate, string firstName, string lastName)
        {
            this._birthDate = birthDate;
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = 21;
        }

        public Human(DateTime birthDate, string firstName, string lastName, int age)
        {
            this._birthDate = birthDate;
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                var anotherHuman = obj as Human;

                if(this._birthDate == anotherHuman._birthDate &&
                    this._firstName == anotherHuman._firstName &&
                    this._lastName == anotherHuman._lastName &&
                    this._age == anotherHuman._age)
                {
                    return true;
                }

                return false;

            }
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            //return base.GetHashCode();
        }

    }
}
