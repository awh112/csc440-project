namespace CSC440_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsAdmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsAdmin");
        }
    }
}
