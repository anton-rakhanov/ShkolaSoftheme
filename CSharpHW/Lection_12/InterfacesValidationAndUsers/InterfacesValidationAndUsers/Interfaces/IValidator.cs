using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesValidationAndUsers.Interfaces
{
    interface IValidator
    {
        void ValidateUser(IUser user);
    }
}
