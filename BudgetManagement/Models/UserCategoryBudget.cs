using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace BudgetManagement.Models
{
    public class UserCategoryBudget
    {
        [Key]
        public int UserCategoryBudgetID { get; set; }
        public ICollection<User> User { get; set; }
        public ICollection<Category> Category { get; set; }

        [StringLength(250, ErrorMessage = "The max number of characters is 250")]
        public string Notes { get; set; }

        [Required]
        public string Colour { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Budget { get; set; }
    }
}
