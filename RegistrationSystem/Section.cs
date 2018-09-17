/************************************
 *  Author : Robert McGuire
 *  Description : Lab 2 Business Classes
 *  Course : C# 2 Programming 
 *  Section class
 * **************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Section
    {
        //Properties
        private string _crn;
        private string _courseID;
        private string _timeDays;
        private string _roomNo;
        private int _instructor;

        //Constructors
        public Section()
        {
            /************************
             * string Crn,
             * string CourseID, 
             * string TimeDays, 
             * string RoomNo, 
             * Int Instructor.
             * 
             * 
             * 
             ***********************/
            string _crn = "";
            string _courseID = "";
            string _timeDays = "";
            string _roomNo = "";
            int _instructor = 0;
        }
        public Section(string tempCrn, string tempCourseID, string tempTimeDays, string tempRoomNo, int tempInstructor)
        {
            /************************
             * string Crn,
             * string CourseID, 
             * string TimeDays, 
             * string RoomNo, 
             * Int Instructor.
             * 
             * 
             * 
             ***********************/
            _crn = tempCrn;
            _courseID = tempCourseID;
            _timeDays = tempTimeDays;
            _roomNo = tempRoomNo;
            _instructor = tempInstructor;

        }//End Constructor Section.

        //Behaviors
        //Setters and Getters. 
        public void SetCRN(string tempCrn)
        {
            _crn = tempCrn;
        }
        public string GetCRN()
        {
            return _crn;
        }
        public void SetCourseID(string tempCourseID)
        {
            _courseID = tempCourseID;
        }
        public string GetCourseID()
        {
            return _courseID;
        }
        public void SetTimeDays(string tempTimeDays)
        {
            _timeDays = tempTimeDays;
        }
        public string GetTimeDays()
        {
            return _timeDays;
        }
        public void SetRoomNo(string tempRoomNo)
        {
            _roomNo = tempRoomNo;
        }
        public string GetRoomNo()
        {
            return _roomNo;
        }
        public void SetInstructor(int tempInstructor)
        {
            _instructor = tempInstructor;
        }
        public int GetInstructor()
        {
            return _instructor;
        }


        public void Display()
        {
            Console.WriteLine("The students course registration number is : " + _crn);
            Console.WriteLine("The course id is : " + _courseID);
            Console.WriteLine("The meeting time is : " + _timeDays);
            Console.WriteLine("The room that class is held at is : " + _roomNo);
            Console.WriteLine("You have instructor : " + _instructor);
        }



    }//End Class.

}//End Namespace.
