using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string Professor { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }
        public double Cost { get; set; }
        //public Dictionary<string, double> Student { get; set; }
        //public Dictionary<string, Student> Student { get; set; }

        public List<Student> Students { get; set; }
    }
}
