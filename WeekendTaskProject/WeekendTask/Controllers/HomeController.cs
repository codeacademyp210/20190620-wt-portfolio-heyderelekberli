using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekendTask.Models;

namespace WeekendTask.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            HomeViewModel models = new HomeViewModel();
            models.Blog = db.Blogs.ToList();
            models.Education = db.Educations.ToList();
            models.Experience = db.Experiences.ToList();
            models.Icon = db.Icons.ToList();
            models.Information = db.Informations.ToList();
            models.Portfolio = db.Portfolios.ToList();
            models.Recoment = db.Recoments.ToList();
            models.Skill = db.Skills.ToList();
            models.Setting = Setting;
            return View(models);
        }
    }
}