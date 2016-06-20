using System;
using System.ComponentModel.DataAnnotations;

namespace Librarium.Data
{
    [Serializable]
    public class LibraryUser
    {
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Wrong entered first name of the User")]
        public string FirstName { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Wrong entered last name of the User")]
        public string LastName { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Wrong entered login of the User")]
        public string Login { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Wrong entered password of the User")]
        public string Password { get; set; }

        public LibraryUser()
        {

        }

        public LibraryUser(string firstName, string lastName, string login, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Login = login;
            this.Password = password;
        }
    }
}
