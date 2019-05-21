using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoClaim.Models
{
    public class Policy
    {
        [Key]
          [Display(Name ="Policy ID")]
        public string Id { get; set; }
        [Required(ErrorMessage ="FirstName is Required")]
        [StringLength(100)]
        
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]

        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [StringLength(10)]
        public string VechicleNumber { get; set; }
        [Required]
        public string VechicleType { get; set; }
        [Required]
        public string VehicleCC { get; set; }
        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email ID")]
        public string EmailId { get; set; }
        [Required]
        [StringLength(300)]
        public string Address { get; set; }
        [Required]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string MobileNo { get; set; }

        //refernce to insurance dont keep required
        public InsurancePolicy insurancePolicy { get; set; }

        public int InsurancePolicyId { get; set; }


    }
}