namespace CSC440_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePercentageChangeType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DetailedOccupations", "PercentageChange", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DetailedOccupations", "PercentageChange", c => c.Int(nullable: false));
        }
    }
}
