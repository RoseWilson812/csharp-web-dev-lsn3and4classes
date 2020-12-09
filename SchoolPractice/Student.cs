using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        double totalQualityScore;
        double currentQualityScore;
        public string Name { get; set; }
        
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
            currentQualityScore = Gpa * NumberOfCredits;

            double qualityScore; 
            qualityScore = courseCredits * grade;
            totalQualityScore = qualityScore + currentQualityScore;

            NumberOfCredits = courseCredits + NumberOfCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            string gradeLevel;
            // Determine the grade level of the student based on NumberOfCredits
            //Freshman (0-29 credits), Sophomore (30-59 credits), Junior (60-89 credits), or Senior (90+ credits)
            if (NumberOfCredits < 30)
            {
                gradeLevel = "Freshman";
            } 
            else if (NumberOfCredits < 60 )
            {
                gradeLevel = "Sophomore";
            }
            else if (NumberOfCredits < 90)
            {
                gradeLevel = "Junior";
            }
            else
            {
                gradeLevel = "Senior";
            }
            return gradeLevel;
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }
        public override string ToString()
        {
            return Name + "(Id: " + StudentId + ", Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }
    }
}
