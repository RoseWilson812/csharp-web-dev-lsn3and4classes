using System;
using System.Collections.Generic;

namespace SchoolPractice
{
	public class Course
	{
		
		public string StudentName { get; set; }
		public int StudentId { get; set; }
		public Dictionary<int, string> Courses {get; set;}
		
		
		public Course(string studentName, int studentId)
	    {
		    StudentName = studentName;
		    StudentId = studentId;
			Courses = new Dictionary<int,string>() ;
			
		}

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   StudentId == course.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }

		public override string ToString()
		{
			return StudentName + " " + StudentId + "  Courses:";
		}
	}
}

