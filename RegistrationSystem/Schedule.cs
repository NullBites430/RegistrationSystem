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
        public void AddSection(Section s)
        {
            //Add the section to the Section Array.
            sections[count] = s;
            count++;
        }//End AddSection

        public void Display()
        {


            //foreach(type identifier in arrayName)
            foreach (Section s1 in sections[count])//this error...
            {
                s1.Display();
            }
            
        }//End Schedule Display.
    }//End Class
}//END namespace
