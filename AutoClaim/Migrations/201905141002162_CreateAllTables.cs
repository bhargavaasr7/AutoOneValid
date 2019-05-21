namespace AutoClaim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assessors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Remarks = c.String(maxLength: 500),
                        SuggestedAmount = c.Double(nullable: false),
                        DamagePercentage = c.Double(nullable: false),
                        ClaimId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Claims", t => t.ClaimId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.ClaimId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Claims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaimAmount = c.Double(nullable: false),
                        MaximumAmount = c.Double(nullable: false),
                        DamagePercentage = c.Double(nullable: false),
                        Description = c.String(nullable: false, maxLength: 500),
                        Status = c.String(nullable: false),
                        PolicyId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Policies", t => t.PolicyId)
                .Index(t => t.PolicyId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Designation = c.String(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Authorizers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        DDNumber = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        ClaimId = c.Int(nullable: false),
                        PolicyId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Claims", t => t.ClaimId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Policies", t => t.PolicyId)
                .Index(t => t.EmployeeId)
                .Index(t => t.ClaimId)
                .Index(t => t.PolicyId);
            
            CreateTable(
                "dbo.RegisteredUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        PolicyId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Policies", t => t.PolicyId)
                .Index(t => t.PolicyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegisteredUsers", "PolicyId", "dbo.Policies");
            DropForeignKey("dbo.Authorizers", "PolicyId", "dbo.Policies");
            DropForeignKey("dbo.Authorizers", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Authorizers", "ClaimId", "dbo.Claims");
            DropForeignKey("dbo.Assessors", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Assessors", "ClaimId", "dbo.Claims");
            DropForeignKey("dbo.Claims", "PolicyId", "dbo.Policies");
            DropIndex("dbo.RegisteredUsers", new[] { "PolicyId" });
            DropIndex("dbo.Authorizers", new[] { "PolicyId" });
            DropIndex("dbo.Authorizers", new[] { "ClaimId" });
            DropIndex("dbo.Authorizers", new[] { "EmployeeId" });
            DropIndex("dbo.Claims", new[] { "PolicyId" });
            DropIndex("dbo.Assessors", new[] { "EmployeeId" });
            DropIndex("dbo.Assessors", new[] { "ClaimId" });
            DropTable("dbo.RegisteredUsers");
            DropTable("dbo.Authorizers");
            DropTable("dbo.Employees");
            DropTable("dbo.Claims");
            DropTable("dbo.Assessors");
        }
    }
}
