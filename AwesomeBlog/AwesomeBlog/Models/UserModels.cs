using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AwesomeBlog.Models
{
    public class Login
    {
        [Required(ErrorMessage="Wow Username is much required")]
        public string Username { get; set; }
        [Required(ErrorMessage="So Password is much required")]
        public string Password { get; set; }
    }

    public class Register
    {
        [Required]
        public string Username { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password),
        Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
