using System;
using System.ComponentModel.DataAnnotations;

namespace Lab21__22.Models
{
    public class RegistrationViewModel
    {
        public RegistrationViewModel()
        {

        }

        [Required]
        [StringLength(50), MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50), MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Level { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
