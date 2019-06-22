namespace WeekendTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Speciality = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Icon = c.String(),
                        Title = c.String(),
                        Text = c.String(),
                        DateTime = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        From = c.String(),
                        To = c.String(),
                        YearsMonth = c.String(),
                        Name = c.String(),
                        City = c.String(),
                        Title = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Icons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IconName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Information",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Icon = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Portfolios",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Recoments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Name = c.String(),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Name = c.String(),
                        Speciality = c.String(),
                        Title1 = c.String(),
                        Title2 = c.String(),
                        Previous = c.String(),
                        Education = c.String(),
                        AboutME = c.String(),
                        Birthday = c.String(),
                        Marital = c.String(),
                        Nationality = c.String(),
                        Skype = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        DataTime = c.String(),
                        Facebook = c.String(),
                        Twitter = c.String(),
                        GooglePlus = c.String(),
                        Foot_Email = c.String(),
                        Foot_Phone = c.String(),
                        Foot_Skype = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Percent = c.String(),
                        Flag = c.String(),
                        Country = c.String(),
                        Level = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
            DropTable("dbo.Settings");
            DropTable("dbo.Recoments");
            DropTable("dbo.Portfolios");
            DropTable("dbo.Information");
            DropTable("dbo.Icons");
            DropTable("dbo.Experiences");
            DropTable("dbo.Educations");
            DropTable("dbo.Blogs");
        }
    }
}
