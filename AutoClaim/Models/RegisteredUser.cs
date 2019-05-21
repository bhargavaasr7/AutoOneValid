using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoClaim.Models
{
    public class RegisteredUser
    {

        public int Id { get; set; }
        [Required]
       [StringLength(50)]
       [Display(Name ="UserName")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public Policy Policy { get; set; }
        public string PolicyId { get; set; }

    }
}