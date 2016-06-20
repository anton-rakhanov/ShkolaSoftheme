using System;
using System.ComponentModel.DataAnnotations;

namespace Librarium.Data
{
    public class LibraryUser
    {
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Wrong entered first name of the User")]
        public string FirstName { get; private set; }


        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Wrong entered last name of the User")]
        public string LastName { get; private set; }


        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Wrong entered login of the User")]
        public string Login { get; private set; }


        [Required]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Wrong entered password of the User")]
        public string Password { get; private set; }


        public LibraryUser(string firstName, string lastName, string login, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Login = login;
            this.Password = password;
        }
    }
}
