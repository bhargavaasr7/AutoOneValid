using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoClaim.Models
{
    public class Claim
    {
         [Key]           
        public int Id { get; set; }  
        
       
        [Required]
        [DataType(DataType.Currency)]
        public double ClaimAmount { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double MaximumAmount { get; set; }
        [Required]
        public double DamagePercentage { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        public string Status { get; set; }

        //refernce to customer 
        //please dont keep  required
        public Policy Policy { get; set; }

        public string PolicyId { get; set; }

    }
}