﻿using System.ComponentModel.DataAnnotations;

namespace DemoPL.ViewModels
{
    public class SignInViewModel
    {


        [Required(ErrorMessage = "Email Is Requried !")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Is Required ")]
        [MinLength(5, ErrorMessage = "Minimum Password Length is 5")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }
}
