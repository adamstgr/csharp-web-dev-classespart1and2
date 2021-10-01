using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student adam = new Student();
            adam.Name = "Adam Steiger";
            adam.StudentId = 6094020;
            adam.NumberOfCredits = 1;
            adam.Gpa = 4.0;
            Console.WriteLine($"The student's name is {adam.Name} and his student ID is {adam.StudentId}. He is currently taking {adam.NumberOfCredits} credit and has a GPA of {adam.Gpa}.");


            Student Ryan = new Student();
            Ryan.Name = "Ryan Shaw";
            Ryan.StudentId = 2;
            Ryan.NumberOfCredits = 1;
            Ryan.Gpa = 3.0;
            Console.WriteLine($"The student's name is {Ryan.Name} and his student ID is {Ryan.StudentId}. He is currently taking {Ryan.NumberOfCredits} credit and has a GPA of {Ryan.Gpa}.");

            Course course = new Course()
            {
                Professor = "Mr. Professor Guy",
                Location = "Moon",
                Students = new List<Student>()
            };

            course.Students.Add(adam);
            course.Students.Add(Ryan);
        }
    }
}
