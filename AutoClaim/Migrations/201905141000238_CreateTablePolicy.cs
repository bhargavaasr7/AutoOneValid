namespace AutoClaim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePolicy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Policies",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Gender = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        VechicleNumber = c.String(nullable: false, maxLength: 10),
                        VechicleType = c.String(nullable: false),
                        EmailId = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 300),
                        MobileNo = c.String(nullable: false, maxLength: 10),
                        InsurancePolicyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InsurancePolicies", t => t.InsurancePolicyId, cascadeDelete: true)
                .Index(t => t.InsurancePolicyId);
            
            CreateTable(
                "dbo.InsurancePolicies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehicleType = c.String(nullable: false),
                        VehicleCC = c.Int(nullable: false),
                        PayableAmount = c.Int(nullable: false),
                        MaximumClaimAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Policies", "InsurancePolicyId", "dbo.InsurancePolicies");
            DropIndex("dbo.Policies", new[] { "InsurancePolicyId" });
            DropTable("dbo.InsurancePolicies");
            DropTable("dbo.Policies");
        }
    }
}
