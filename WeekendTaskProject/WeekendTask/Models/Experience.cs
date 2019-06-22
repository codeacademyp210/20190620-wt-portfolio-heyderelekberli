using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeekendTask.Models
{
    public class Experience
    {
        public int ID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string YearsMonth { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}