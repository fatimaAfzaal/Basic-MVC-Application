using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab11_VP.Models
{
    public class Student
    {
        public int id { get; set; }
        public String full_name { get; set; }
        public String contact { get; set; }
        public String  address { get; set; }
        public String gender { get; set; }
        public double cgpa { get; set; }

    }
}