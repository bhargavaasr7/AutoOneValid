using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AutoClaim.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("AutoClaim")
        { }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }
        public DbSet<Assessor> Assessors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Authorizer> Authorizers { get; set; }

    }
}