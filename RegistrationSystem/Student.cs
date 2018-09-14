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
        public Student(string tempId, double tempGpa, string fname, string lname, string email, Address a) : base(fname, lname, email, a)
        {
            id = tempId;
            gpa = tempGpa;
#pragma warning disable CS1717 // Assignment made to same variable
            fname = fname;
#pragma warning restore CS1717 // Assignment made to same variable
#pragma warning disable CS1717 // Assignment made to same variable
            lname = lname;
#pragma warning restore CS1717 // Assignment made to same variable
#pragma warning disable CS1717 // Assignment made to same variable
            email = email;
#pragma warning restore CS1717 // Assignment made to same variable
#pragma warning disable CS1717 // Assignment made to same variable
            a1 = a;
#pragma warning restore CS1717 // Assignment made to same variable

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
            Console.WriteLine("ID is:" + id);
            Console.WriteLine("Gpa is : " + gpa);
            base.Display();
        }

    }//End Class
}//End Namespace
