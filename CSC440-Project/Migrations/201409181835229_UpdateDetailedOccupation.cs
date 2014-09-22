namespace CSC440_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDetailedOccupation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DetailedOccupations", "OccupationalCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DetailedOccupations", "OccupationalCode", c => c.Int(nullable: false));
        }
    }
}
