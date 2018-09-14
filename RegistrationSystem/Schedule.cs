/************************************
 *  Author : Robert McGuire
 *  Description : Lab 2 Business Classes
 *  Course : C# 2 Programming 
 *  Schedule Class
 * **************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Schedule
    {
        //Is a list of Sections =)
        //Properties...
        public int count = 0;
        public Section[] sections = new Section[10];
        
        //Constructor
        public Schedule() { }

        //Behaviors
        public void AddSection(Section section)
        {
            //Add the section to the Section Array.
            sections[count] = section;
            count++;
        }//End AddSection

        public void Display()
        {
            
            Console.WriteLine("The Crn  is: " +_crn);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //string _crn = "";
            //string _courseID = "";
            //string _timeDays = "";
            //string _roomNo = "";
            //int _instructor = 0;
        }
    }//End Class
}//END namespace
