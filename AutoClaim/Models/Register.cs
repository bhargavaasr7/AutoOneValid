using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AutoClaim.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50,ErrorMessage ="UserName Can't exceed morethan 50 characters")]
        [Display(Name ="UserName")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [StringLength(8,ErrorMessage ="Password length should be 8")]
        [Display(Name ="Password")]
        public string Password { get; set; }
    }
}