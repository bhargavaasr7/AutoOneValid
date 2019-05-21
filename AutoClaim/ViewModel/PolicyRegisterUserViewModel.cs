using AutoClaim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoClaim.ViewModel
{
    public class PolicyRegisterUserViewModel
    {
        public Policy Policy { get; set; }
        public RegisteredUser registeredUser  { get; set; }
    }
}