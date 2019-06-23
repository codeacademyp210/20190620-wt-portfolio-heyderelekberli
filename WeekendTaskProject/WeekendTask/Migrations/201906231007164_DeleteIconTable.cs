namespace WeekendTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIconTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "SkypeIcon", c => c.String());
            AddColumn("dbo.Settings", "Envelope", c => c.String());
            AddColumn("dbo.Settings", "PhoneIcon", c => c.String());
            AddColumn("dbo.Settings", "Share", c => c.String());
            DropTable("dbo.Icons");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Icons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IconName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.Settings", "Share");
            DropColumn("dbo.Settings", "PhoneIcon");
            DropColumn("dbo.Settings", "Envelope");
            DropColumn("dbo.Settings", "SkypeIcon");
        }
    }
}
