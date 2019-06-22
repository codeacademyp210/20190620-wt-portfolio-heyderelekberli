using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeekendTask.Models
{
    public class Skill
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Percent { get; set; }
        public string Flag { get; set; }
        public string Country { get; set; }
        public string Level { get; set; }
    }
}