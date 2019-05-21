using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoClaim.Models
{
    public class Assessor
    {
        [Display(Name = "Assessor ID")]
        public int Id { get; set; }
        [StringLength(500)]
        public string Remarks { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double SuggestedAmount { get; set; }
        [Required]
        public double DamagePercentage { get; set; }

        //refernce to claim 
        //please dont keep  required
        public Claim Claim { get; set; }

        public int ClaimId { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

    }
}