using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeekendTask.Models;

namespace WeekendTask.DAL
{
    public class TempleteContext : DbContext
    {
        public TempleteContext() : base("TempleteConnection")
        {
        }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Recoment> Recoments { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Skill2> Skills2 { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Setting> Settings { get; set; }

    
    }
}