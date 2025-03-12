using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Registered
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}