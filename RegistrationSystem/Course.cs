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
        private String courseID;
        private String courseName;
        private String description;
        private double creditHours;

        //Constructors

        public Course()
        {
            courseID = "";
            courseName = "";
            description = "";
            creditHours = 0.0;
        }//End Default

        public Course(String tempCourseID, String tempCourseName, String tempDescription, double tempCreditHours)
        {
            courseID = tempCourseID;
            courseName = tempCourseName;
            description = tempDescription;
            creditHours = tempCreditHours;
        }//End All Args

        //Behaviors
        public void SetCourseID(String tempCourseID)
        {
            courseID = tempCourseID;
        }
        public String GetCourseID()
        {
            return courseID;
        }

        public void SetCourseName(String tempCourseName)
        {
            courseName = tempCourseName;
        }

        public String GetCourseName()
        {
            return courseName;
        }

        public void SetCourseDescription(String tempDescription)
        {
            description = tempDescription;
        }

        public String GetDescription()
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
            Console.WriteLine("========= Course Class ===========");
            Console.WriteLine("Course Id is: " + courseID);
            Console.WriteLine("Course name is: " + courseName);
            Console.WriteLine("The course description is: " + description);
            Console.WriteLine("Class carrys: " + creditHours + " credit hours");

        }

    }//End Class 
}//End Namespace

