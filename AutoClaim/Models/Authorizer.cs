using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoClaim.Models
{
    public class Authorizer
    {
        [Display(Name = "Policy ID")]
        public string Id { get; set; }
        [Required]
        public int DDNumber { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }

        //refernce to employee
        //please dont keep  required
        public Employee employee { get; set; }
        public int EmployeeId { get; set; }


        //refernce to claim 
        //please dont keep  required
        public Claim Claim { get; set; }

        public int ClaimId { get; set; }

        public Policy Policy { get; set; }
        public string PolicyId { get; set; }

    }
}