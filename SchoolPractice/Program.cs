using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student roseStudent = new Student("Rose", 1, 1, 4.0);
            Course roseCourse = new Course(roseStudent.Name, roseStudent.StudentId);
            //
            roseCourse.Courses.Add(1001, "Intro To Programming");
            //
            Teacher roseTeacher = new Teacher("Louise", "Hirsch", "Gym", 30);
           
            //string printStudent = roseStudent.ToString();
            Console.WriteLine(roseStudent.ToString());
            
            
            Console.WriteLine(roseCourse.ToString());
            
            foreach (var pair in roseCourse.Courses)
            {
                Console.WriteLine("Course Number: " + pair.Key + ", Course Name: " + pair.Value);
            }

            Console.WriteLine(roseTeacher.ToString());
            
        }
    }
}
