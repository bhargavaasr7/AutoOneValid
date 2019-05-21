namespace AutoClaim.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterInsurancepolicyTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Policies", "VehicleCC", c => c.String(nullable: false));
            AlterColumn("dbo.InsurancePolicies", "VehicleCC", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.InsurancePolicies", "VehicleCC", c => c.Int(nullable: false));
            DropColumn("dbo.Policies", "VehicleCC");
        }
    }
}
