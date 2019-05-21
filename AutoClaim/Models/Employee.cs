using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoClaim.Models
{
    public class Employee
    {
        [Display(Name = "Employee ID")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        [StringLength(100)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        
    }
}