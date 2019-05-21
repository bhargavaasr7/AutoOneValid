using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoClaim.Models
{
    public class InsurancePolicy
    {
        [Display(Name = "Insurance ID")]
        public int Id { get; set; }
        [Required]
        public string VehicleType { get; set; }

        [Required]
        public string VehicleCC { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int PayableAmount { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int MaximumClaimAmount { get; set; }

        //refernce to 
    }
}