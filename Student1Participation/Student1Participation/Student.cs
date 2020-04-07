using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1Participation
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<string> CourseNames { get; set; }

        public List<string> CourseGrades { get; set; }

        public Student()
        {
            FirstName = "";
            LastName = "";
        }

        public Student(string first, string second)
        {
            FirstName = first;
            LastName = second;
            
        }

        public double CalculateGPA()
        {

            double totalPoints = totalPoints;



        }
    }
}
