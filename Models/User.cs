using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC_CRUD.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required (ErrorMessage = "Please fill out name!")]

        public string Name { get; set; }

        [Required]

        public string Address { get; set; }
        [Required]

        public string EmailAddress { get; set; }

        [Required]

        public string Password { get; set; }
    }
}
