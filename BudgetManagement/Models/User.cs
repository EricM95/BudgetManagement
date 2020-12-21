using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;


namespace ApplicatonDbContext.Models
{
    public class User : IdentityUser
    {
        [Key]
        [Required]
        public int UserID { get; set; }
        public ICollection<Account> Accounts { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
