using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesValidationAndUsers.Interfaces;

namespace InterfacesValidationAndUsers.Data.Validators
{
    public class NameValidator : MainValidator
    {
        bool isUserExist = false;

        public override void ValidateUser(IUser user)
        {
            for(int i = 0; i <= _lastRecordIndex; i++)
            {
                if(base.UsersDataBase[0, i].Contains(user.Name) &&
                   base.UsersDataBase[2, i].Contains(user.Password))
                {
                    Console.WriteLine("\nValidation was successful, dear {0}, last time when you entered was {1}", user.Name, DateTime.Now);
                    isUserExist = true;
                    break;
                }
            }
            if (!isUserExist)
            {

                _lastRecordIndex++;

                base.UsersDataBase[0, _lastRecordIndex] = user.Name;
                base.UsersDataBase[1, _lastRecordIndex] = user.Email == null ? user.Email = "No data" : user.Email;
                base.UsersDataBase[2, _lastRecordIndex] = user.Password;

                Console.WriteLine("\nNew user was successfuly added to the database");
            }
        }

        public override void DownloadUsersDataBase(string[,] userNameEmailPasswordDimension, int lastRecordIndex)
        {
            if(userNameEmailPasswordDimension != null)
            {
                base.UsersDataBase = userNameEmailPasswordDimension;
                _lastRecordIndex = lastRecordIndex;
            }
        }
    }
}
