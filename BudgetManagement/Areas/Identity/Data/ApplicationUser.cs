using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Identity;


namespace BudgetManagement.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", 
            ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
