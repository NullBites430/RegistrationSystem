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
        private String _crn;
        private String _courseID;
        private String _timeDays;
        private String _roomNo;
        private int _instructor;

        //Constructors
        public Section()
        {
            /************************
             * String Crn,
             * String CourseID, 
             * String TimeDays, 
             * String RoomNo, 
             * Int Instructor.
             * 
             * 
             * 
             ***********************/
            String _crn = "";
            String _courseID = "";
            String _timeDays = "";
            String _roomNo = "";
            int _instructor = 0;
        }
        public Section(String tempCrn, String tempCourseID, String tempTimeDays, String tempRoomNo, int tempInstructor)
        {
            /************************
             * String Crn,
             * String CourseID, 
             * String TimeDays, 
             * String RoomNo, 
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
        public void SetCRN(String tempCrn)
        {
            _crn = tempCrn;
        }
        public String GetCRN()
        {
            return _crn;
        }
        public void SetCourseID(String tempCourseID)
        {
            _courseID = tempCourseID;
        }
        public String GetCourseID()
        {
            return _courseID;
        }
        public void SetTimeDays(String tempTimeDays)
        {
            _timeDays = tempTimeDays;
        }
        public String GetTimeDays()
        {
            return _timeDays;
        }
        public void SetRoomNo(String tempRoomNo)
        {
            _roomNo = tempRoomNo;
        }
        public String GetRoomNo()
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
            Console.WriteLine("*****************************");
            Console.WriteLine("**** Section Display ********");
            Console.WriteLine("***                  ********");
            Console.WriteLine("The students course registration number is : " + _crn);
            Console.WriteLine("The course id is : " + _courseID);
            Console.WriteLine("The meeting time is : " + _timeDays);
            Console.WriteLine("The room that class is held at is : " + _roomNo);
            Console.WriteLine("You have instructor : " + _instructor);
        }



    }//End Class.

}//End Namespace.
