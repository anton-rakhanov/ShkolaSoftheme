﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignarDTOModels.AsignarDatabaseDTOs
{
    public class UserDTO
    {
        [Required]
        
        public string FirstNam { get; set; }


        public string MyProperty { get; set; }


        public string Email { get; set; }


        public string Password { get; set; }


        public bool IsAdmin { get; set; }


        public UserDTO()
        {

        }
    }
}
