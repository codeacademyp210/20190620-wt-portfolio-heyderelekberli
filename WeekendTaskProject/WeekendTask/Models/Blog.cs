using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeekendTask.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Speciality { get; set; }
        public string Text { get; set; }
    }
}