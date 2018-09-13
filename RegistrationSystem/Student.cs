/****************************************
 *  Author : Robert McGuire
 *  Description : Lab 3 Inheritance
 *  Course : C# 2 Programming 
 *  Student class "Child-Class" extends Person
 * **************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem 
{
    //Below we have some inheritance going on here.
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
        public Student(string tempId, double tempGpa, string fname, string lname, string email, string address) : base(fname, lname, email, address)
        {
            id = tempId;
            gpa = tempGpa;
            fname = fname;
            lname = lname;
            email = email;
            address = address;

        }//End Student all arg Constructor.
        

        //========== id ===================
        public void SetStudentId(string tempId)
        {
            id = tempId;
        }

        public string GetStudentId() { return id; }

        //=========== gpa ==================
        public void SetGpa(double tempGpa)
        {
            gpa = tempGpa;
        }

        public double GetGpa() { return gpa; }

        public void Display()

        {
            Console.WriteLine("*****************************");
            Console.WriteLine("**** Student Display ********");
            Console.WriteLine("***                  ********");
            Console.WriteLine("ID is:" + id);
            Console.WriteLine("Gpa is : " + gpa);
            Console.WriteLine("First Name is : " + fname);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }

    }//End Class
}//End Namespace
