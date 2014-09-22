namespace CSC440_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectOpeningsAndReplacementsGrowth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DetailedOccupations", "OpeningsAndReplacementsGrowth", c => c.Int(nullable: false));
            DropColumn("dbo.DetailedOccupations", "OpeningsAndReplacmentsGrowth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DetailedOccupations", "OpeningsAndReplacmentsGrowth", c => c.Int(nullable: false));
            DropColumn("dbo.DetailedOccupations", "OpeningsAndReplacementsGrowth");
        }
    }
}
