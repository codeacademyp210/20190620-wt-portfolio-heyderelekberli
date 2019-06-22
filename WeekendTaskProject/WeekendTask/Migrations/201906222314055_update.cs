namespace WeekendTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Skills", "Flag");
            DropColumn("dbo.Skills", "Country");
            DropColumn("dbo.Skills", "Level");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Skills", "Level", c => c.String());
            AddColumn("dbo.Skills", "Country", c => c.String());
            AddColumn("dbo.Skills", "Flag", c => c.String());
        }
    }
}
