using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesValidationAndUsers.Interfaces;

namespace InterfacesValidationAndUsers.Data.Validators
{
    public abstract class MainValidator: IValidator
    {
        // This multidimensional array must have next structure:
        // User name [-----------------------------------------]
        // User email [----------------------------------------]
        // User password [-------------------------------------]
        protected string[,] UsersDataBase;

        // Information about last record index for valid search operations.
        protected static int _lastRecordIndex;

        public abstract void ValidateUser(IUser user);

        public abstract void DownloadUsersDataBase(string[,] userNameEmailPasswordDimension, int lastRecordIndex);
    }
}
