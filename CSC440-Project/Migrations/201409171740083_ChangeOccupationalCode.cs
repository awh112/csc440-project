namespace CSC440_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeOccupationalCode : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OccupationalGroups", "OccupationalCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OccupationalGroups", "OccupationalCode", c => c.Int(nullable: false));
        }
    }
}
