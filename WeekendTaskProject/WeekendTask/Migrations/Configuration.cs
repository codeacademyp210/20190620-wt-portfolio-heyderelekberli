namespace WeekendTask.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WeekendTask.DAL.TempleteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WeekendTask.DAL.TempleteContext context)
        {
            context.Blogs.AddOrUpdate(b => b.ID,
           new Models.Blog { ID = 1, Image = "blog-1.jpg", Speciality = "Design Driven", Text= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapib..." },
           new Models.Blog { ID = 2, Image = "blog-2.jpg", Speciality = "UI, UX Concepts", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique..." }
           );
            context.Educations.AddOrUpdate(e => e.ID,
            new Models.Education { ID = 1, Icon = "graduation", Title = "Porto University", Text = "Master of Information Technology", DateTime = "2001-2017" },
            new Models.Education { ID = 2, Icon = "graduation", Title = "Porto University", Text = "Master of Information Technology", DateTime = "2001-2017" },
            new Models.Education { ID = 3, Icon = "graduation", Title = "Porto University", Text = "Master of Information Technology", DateTime = "2001-2017" },
            new Models.Education { ID = 4, Icon = "graduation", Title = "Porto University", Text = "Master of Information Technology", DateTime = "2001-2017" },
            new Models.Education { ID = 5, Icon = "graduation", Title = "Porto University", Text = "Master of Information Technology", DateTime = "2001-2017" },
            new Models.Education { ID = 6, Icon = "graduation", Title = "Porto University", Text = "Master of Information Technology", DateTime = "2001-2017" }
                ) ;
            context.Experiences.AddOrUpdate(ex => ex.ID,
                new Models.Experience { ID = 1, From = "Sep 2012", To = "Present", YearsMonth = "(3 YEARS 9 MONTHS)", Name = "Okler Themes", City = "GREATER NEW YORK", Title = "Chief Product Officer", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." },
                new Models.Experience { ID = 2, From = "Sep 2012", To = "Present", YearsMonth = "(3 YEARS 9 MONTHS)", Name = "Okler Themes", City = "GREATER NEW YORK", Title = "Chief Product Officer", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." },
                new Models.Experience { ID = 3, From = "Sep 2012", To = "Present", YearsMonth = "(3 YEARS 9 MONTHS)", Name = "Okler Themes", City = "GREATER NEW YORK", Title = "Chief Product Officer", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." }
                );
        
            context.Informations.AddOrUpdate(inf => inf.ID,
                new Models.Information { ID = 1, Icon = "earphones-alt", Title = "Contact Information"},
                new Models.Information { ID = 2, Icon = "envelope-open", Title = "Send Message"},
                new Models.Information { ID = 3, Icon = "cloud-download", Title = "Download Resume"}
                );
            context.Portfolios.AddOrUpdate(po => po.ID,
              new Models.Portfolio { ID = 1, Image = "portfolio-1.jpg" },
              new Models.Portfolio { ID = 2, Image = "portfolio-2.jpg" },
              new Models.Portfolio { ID = 3, Image = "portfolio-3.jpg" },
              new Models.Portfolio { ID = 4, Image = "portfolio-4.jpg" },
              new Models.Portfolio { ID = 5, Image = "portfolio-5.jpg" },
              new Models.Portfolio { ID = 6, Image = "portfolio-6.jpg" },
              new Models.Portfolio { ID = 7, Image = "portfolio-7.jpg" },
              new Models.Portfolio { ID = 8, Image = "portfolio-8.jpg" }
               );
            context.Recoments.AddOrUpdate(re => re.ID,
            new Models.Recoment { ID = 1, Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu. Praesent aliquam velit vel libero dictum, non sollicitudin lectus mollis. Morbi sollicitudin auctor gravida.", Name = "Bob Doe",Position="Director of Engineering" },
            new Models.Recoment { ID = 2, Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu. Praesent aliquam velit vel libero dictum, non sollicitudin lectus mollis. Morbi sollicitudin auctor gravida.", Name = "Bob Doe",Position= "Director of Engineering" }
            );
            context.Skills.AddOrUpdate(s => s.ID,
            new Models.Skill { ID = 1, Name = "START UP", Percent = "60%" },
            new Models.Skill { ID = 2, Name = "INNOVATION", Percent = "80%" },
            new Models.Skill { ID = 3, Name = "PRODUCTS", Percent = "70%" },
            new Models.Skill { ID = 4, Name = "CSS", Percent = "90%"}
 
            );
            context.Skills2.AddOrUpdate(sl => sl.ID,
         new Models.Skill2 { ID = 1, Name = "JAVASCRIPT", Percent = "60%" },
         new Models.Skill2 { ID = 2, Name = "BUSINESS", Percent = "80%" },
         new Models.Skill2 { ID = 3, Name = "E-COMMERCE", Percent = "70%" },
         new Models.Skill2 { ID = 4, Name = "CREATIVE", Percent = "90%" }
         );
            context.Languages.AddOrUpdate(la => la.ID,
   new Models.Language { ID = 1, Flag = "united-kingdom.svg", Country = "English", Level ="Advanced" },
   new Models.Language { ID = 2, Flag = "spain.svg", Country = "Spanish", Level ="Advanced" },
   new Models.Language { ID = 3, Flag = "france.svg", Country = "French", Level ="Basic" }
   );
            context.Settings.AddOrUpdate(se => se.ID,
            new Models.Setting
            {
                ID = 1,
                Name = "Adam Doe",
                Speciality = "Chief Product Officer at Okler Themes",
                Title1 = "GREATER NEW YORK AREA",
                Title2 = "INFORMATION TECHNOLOGY & SERVICES",
                Previous = "FRONT-END DEVELOPER AT PORTO ",
                Education = "PORTO SCHOOL",
                AboutME = "Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui.",
                Birthday = "1990 OCTOBER 2",
                Marital = "SINGLE",
                Nationality = "AMERICAN",
                Skype = "YOURSKYPE",
                Phone = "123-456-789",
                Email = "ME@DOMAIN.COM",
                DataTime = "JULY 12-2017",
                Facebook = "Facebook",
                Twitter = "Twitter",
                GooglePlus = "Google Plus",
                Foot_Email = "you@domain.com",
                Foot_Phone = "123-456-7890",
                Foot_Skype = "yourskype",
                Envelope = "envelope",
                PhoneIcon = "phone",
                SkypeIcon = "social-skype",
                Share = "share"
        });
        }
   
    }
}
