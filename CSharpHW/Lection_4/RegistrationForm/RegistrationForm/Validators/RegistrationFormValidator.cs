using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegistrationForm.Validators
{
    public class RegistrationFormValidator
    {

        private static bool[] _isAllInputValid = new bool[7];

        static RegistrationFormValidator()
        {
            _isAllInputValid[6] = true;
        }

        public static bool IsAllInputValid
        {
            get 
            { 
                foreach(bool flag in _isAllInputValid)
                {
                    if(!flag)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        

        public static bool IsValidFirstName(string name)
        {
            bool isValid;

            isValid = name.Length < 255 && (name.Length == Regex.Matches(name, "[a-zA-Z]").Count) ? true : false;
            _isAllInputValid[0] = isValid;
            return isValid;
        }

        public static bool IsValidLastName(string name)
        {
            bool isValid;

            isValid = name.Length < 255 && (name.Length == Regex.Matches(name, "[a-zA-Z]").Count) ? true : false;
            _isAllInputValid[1] = isValid;
            return isValid;
        }

        public static bool TryParseBirthDate(string stringBirthDate, out DateTime validBirthDate)
        {
            string[] birthDateArray;

            birthDateArray = stringBirthDate.Split('.', ',', '/');

            int day;
            int month;
            int year;

            DateTime birthDate;

            if (birthDateArray.Length == 3 &&
                int.TryParse(birthDateArray[0], out day) &&
                int.TryParse(birthDateArray[1], out month) &&
                int.TryParse(birthDateArray[2], out year) &&
                DateTime.TryParse(stringBirthDate, out birthDate) &&
                day > 0 && day < 32 &&
                month > 0 && month < 13 &&
                year > 1900 && year < DateTime.Now.Year)
            {
                birthDate = new DateTime(year, month, day);
                validBirthDate = DateTime.MinValue;
                return _isAllInputValid[2] = true;
            }
            else
            {
                validBirthDate = DateTime.MinValue;
                return _isAllInputValid[2] = false;

            }
        }

        public static bool isValidGender(string gender)
        {
            bool isValid;

            isValid = (gender == "Female" || gender == "Male") ? true : false;
            _isAllInputValid[3] = isValid;
            return isValid;
        }

        public static bool IsValidEmail(string email)
        {
            if( (email.Length < 255 && Regex.Matches(email, "@").Count == 1))
            {
                return _isAllInputValid[4] = true;
            }
            else
            {
                return _isAllInputValid[4] = false;
            }
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if(phoneNumber.Length == 12 && 
               Regex.Matches(phoneNumber, "[0-9]").Count == phoneNumber.Length)
            {
                return _isAllInputValid[5] = true;
            }
            else
            {
                return _isAllInputValid[5] = false;
            }
        }

        public static bool IsValidAdditionalInfo(string additionalInfo)
        {
            bool isValid;

            isValid = additionalInfo.Length < 2000 ? true : false;
            _isAllInputValid[6] = isValid;
            return isValid;
        }
    }
}
