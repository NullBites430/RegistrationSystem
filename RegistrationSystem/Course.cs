/************************************
 *  Author : Robert McGuire
 *  Description : Lab 2 Business Classes
 *  Course : C# 2 Programming 
 *  Couses class
 * **************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Course
    {
        //Properties
        private string courseID;
        private string courseName;
        private string description;
        private double creditHours;

        //Constructors

        public Course()
        {
            courseID = "";
            courseName = "";
            description = "";
            creditHours = 0.0;
        }//End Default

        public Course(string tempCourseID, string tempCourseName, string tempDescription, double tempCreditHours)
        {
            courseID = tempCourseID;
            courseName = tempCourseName;
            description = tempDescription;
            creditHours = tempCreditHours;
        }//End All Args

        //Behaviors
        public void SetCourseID(string tempCourseID)
        {
            courseID = tempCourseID;
        }
        public string GetCourseID()
        {
            return courseID;
        }

        public void SetCourseName(string tempCourseName)
        {
            courseName = tempCourseName;
        }

        public string GetCourseName()
        {
            return courseName;
        }

        public void SetCourseDescription(string tempDescription)
        {
            description = tempDescription;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetCreditHours(double tempCreditHours)
        {
            creditHours = tempCreditHours;
        }

        public double GetCreditHours()
        {
            return creditHours;
        }

        public void Display()
        {
            Console.WriteLine("Course Id is: " + courseID);
            Console.WriteLine("Course name is: " + courseName);
            Console.WriteLine("The course description is: " + description);
            Console.WriteLine("Class carrys: " + creditHours + " credit hours");

        }

    }//End Class 
}//End Namespace

