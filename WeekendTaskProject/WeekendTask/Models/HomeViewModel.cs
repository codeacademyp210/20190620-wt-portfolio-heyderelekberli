using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeekendTask.Models
{
    public class HomeViewModel 
    {
        public List<Blog> Blog { get; set; }
        public List<Education> Education { get; set; }
        public List<Experience> Experience { get; set; }
        public List<Icon> Icon { get; set; }
        public List<Information> Information { get; set; }
        public List<Portfolio> Portfolio { get; set; }
        public List<Recoment> Recoment { get; set; }
        public List<Skill> Skill { get; set; }
        public Setting Setting { get; set; }
       
    }
}