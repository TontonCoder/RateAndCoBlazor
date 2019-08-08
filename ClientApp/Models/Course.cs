using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Models
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool active { get; set; }
    }
}
