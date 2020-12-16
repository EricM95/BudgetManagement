using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;



namespace BudgetManagement.Models
{
    public class User
    {

        public int UsersID { get; set; }

        public ICollection<Account> Accounts { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
    }
}
