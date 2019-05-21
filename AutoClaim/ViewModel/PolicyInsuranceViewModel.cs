using AutoClaim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoClaim.ViewModel;

namespace AutoClaim.ViewModel
{
    public class PolicyInsuranceViewModel
    {
        public Policy Policy { get; set; }
        public List<InsurancePolicy> InsurancePolicies { get; set; }

    }
}