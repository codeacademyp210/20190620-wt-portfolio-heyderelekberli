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
        protected Icon Icon;
        protected Information Information;
        protected Portfolio Portfolio;
        protected Recoment Recoment;
        protected Skill Skill;
        protected Setting Setting;

        protected BaseController()
        {
            db = new TempleteContext();
            Blog = db.Blogs.FirstOrDefault();
            Education = db.Educations.FirstOrDefault();
            Experience = db.Experiences.FirstOrDefault();
            Icon = db.Icons.FirstOrDefault();
            Information = db.Informations.FirstOrDefault();
            Portfolio = db.Portfolios.FirstOrDefault();
            Recoment = db.Recoments.FirstOrDefault();
            Skill = db.Skills.FirstOrDefault();
            Setting = db.Settings.FirstOrDefault();
        }

    }
}