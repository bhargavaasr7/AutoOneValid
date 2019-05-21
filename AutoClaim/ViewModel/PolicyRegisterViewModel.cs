using AutoClaim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoClaim.ViewModel
{
    public class PolicyRegisterViewModel
    {
        public Policy Policy { get; set; }
        public List<RegisteredUser> RegisteredUser { get; set; }
    }
}