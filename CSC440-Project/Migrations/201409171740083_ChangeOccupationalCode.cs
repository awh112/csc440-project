namespace CSC440_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeOccupationalCode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetailedOccupations",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    OccupationalCode = c.Int(nullable: false),
                    Title = c.String(),
                    OccupationalGroupId = c.Int(nullable: false),
                    CurrentEmployment = c.Int(nullable: false),
                    FutureEmployment = c.Int(nullable: false),
                    NumberChange = c.Int(nullable: false),
                    PercentageChange = c.Int(nullable: false),
                    OpeningsAndReplacmentsGrowth = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OccupationalGroups", t => t.OccupationalGroupId, cascadeDelete: true)
                .Index(t => t.OccupationalGroupId);

            CreateTable(
                "dbo.OccupationalGroups",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    OccupationalCode = c.Int(nullable: false),
                    GroupName = c.String(),
                    CurrentEmploymentNumber = c.Int(nullable: false),
                    FutureEmploymentNumber = c.Int(nullable: false),
                    PercentChange = c.Double(nullable: false),
                    NumberChange = c.Int(nullable: false),
                    Replacements = c.Int(nullable: false),
                    Openings = c.Int(nullable: false),
                    MedianAnnualWage = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            AlterColumn("dbo.OccupationalGroups", "OccupationalCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OccupationalGroups", "OccupationalCode", c => c.Int(nullable: false));
        }
    }
}
