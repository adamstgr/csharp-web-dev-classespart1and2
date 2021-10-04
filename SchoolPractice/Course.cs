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

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Professor == course.Professor &&
                   Location == course.Location &&
                   Time == course.Time;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Professor, Location, Time);
        }

        public override string ToString()
        {
            return $"{Professor} teaches at {Time} at {Location}.";
        }

    }
}
