using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekendTask.DAL;
using WeekendTask.Models;

namespace WeekendTask.Controllers
{
    public class BaseController : Controller
    {
        protected TempleteContext db;
        protected Blog Blog;
        protected Education Education;
        protected Experience Experience;
        protected Information Information;
        protected Portfolio Portfolio;
        protected Recoment Recoment;
        protected Skill Skill;
        protected Skill2 Skill2;
        protected Language Language;
        protected Setting Setting;

        protected BaseController()
        {
            db = new TempleteContext();
            Blog = db.Blogs.FirstOrDefault();
            Education = db.Educations.FirstOrDefault();
            Experience = db.Experiences.FirstOrDefault();
            Information = db.Informations.FirstOrDefault();
            Portfolio = db.Portfolios.FirstOrDefault();
            Recoment = db.Recoments.FirstOrDefault();
            Skill = db.Skills.FirstOrDefault();
            Skill2 = db.Skills2.FirstOrDefault();
            Language = db.Languages.FirstOrDefault();
            Setting = db.Settings.FirstOrDefault();
        }

    }
}