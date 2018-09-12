/****************************************
 *  Author : Robert McGuire
 *  Description : Lab 3 Inheritance
 *  Course : C# 2 Programming 
 *  Student class "Child-Class"
 * **************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Student : Person{
        //properties that student has
        private string id;
        private double gpa;

        //constructors.
        public Student()
        {
            id = "";
            gpa = 0.0; 
        }
        //////            fname = "";
        ////lname = "";
        ////    email = "";
        ////    address = "";
        public Student(string id, double gpa, string fname, string lname, string email, string address) : base(fname, lname, email, address)
        {

        }//End Student all arg Constructor.
        

        

















    }//End Class
}//End Namespace
