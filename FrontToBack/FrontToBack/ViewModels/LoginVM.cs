﻿using System.ComponentModel.DataAnnotations;

namespace FrontToBack.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string UserName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
