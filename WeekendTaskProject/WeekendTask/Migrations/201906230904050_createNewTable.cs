namespace WeekendTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createNewTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Flag = c.String(),
                        Country = c.String(),
                        Level = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Skill2",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Percent = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skill2");
            DropTable("dbo.Languages");
        }
    }
}
