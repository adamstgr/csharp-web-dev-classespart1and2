using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }
    
    public void AddGrade(int courseCredits, double grade)
    {

        double currentTotalQualScore = this.Gpa * this.NumberOfCredits;
        double updatedTotatQualScore = courseCredits * grade + currentTotalQualScore;
        
        double currentCredits = this.NumberOfCredits + courseCredits;
        double currentGpa = updatedTotatQualScore / currentCredits;
           Console.WriteLine(currentGpa);


        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   StudentId == student.StudentId;
        }

        public string GetGradeLevel()
    {
        if (this.NumberOfCredits < 30)
        {
            return "This student is a freshman.";
        }
        else if (30 <= this.NumberOfCredits && this.NumberOfCredits < 59)
        {
            return "This student is a sophomore.";
        }
        else if (60 <= this.NumberOfCredits && this.NumberOfCredits < 89)
        {
            return "This student is a junior.";
        }
        else
        {
            return "This student is a senior.";
        }
    }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId);
        }

        public override string ToString()
        {
            return $"{Name} has a {Gpa} with {NumberOfCredits}.";
        }
        
    }
}
