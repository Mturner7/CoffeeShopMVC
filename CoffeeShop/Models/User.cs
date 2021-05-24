using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a username within 50 characters"), StringLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage = "'First name' cannot be empty!"), StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "'Last name' cannot be empty!"), StringLength(50)]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        [Required(ErrorMessage = "'Email' cannot be empty!!"), StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "'Phone Number' cannot be empty!!"), StringLength(11)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "'Password' cannot be empty!!"), StringLength(30)]
        public string Password { get; set; }
    }
}
