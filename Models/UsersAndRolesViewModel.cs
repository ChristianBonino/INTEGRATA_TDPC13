﻿
using INTEGRATA_TDPC13.Common;
using INTEGRATA_TDPC13.DB.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEGRATA_TDPC13.Models
{
    public class UsersAndRolesViewModel
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<DB.Entities.Role> Roles { get; set; } = new List<DB.Entities.Role>();
        public string UserID { get; set; }
        public int TotalEntitiesNumber { get; set; }
        public int CurrentPage { get; set; }
        public string UserName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [MinLength(ConstantValues.PasswordMinLenght, ErrorMessage = "The {0} must be at least {1} characters long.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}