/************************************
 *  Author : Robert McGuire
 *  Description : Lab 2 Business Classes
 *  Course : C# 2 Programming 
 *  Instructor class
 * **************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Instructor : Person
    {
        //Properties
        private string id;
        private string office;
        


        //Constructors
        public Instructor()
        {
            id = "";
            office = "";
        }

        public Instructor(string id, string office, string fname, string lname, string email, Address a) : base(fname, lname, email, a) 
        {
            this.id = id;
            this.office = office;
            fname = fname;
            lname = lname;
            email = email;
            a1 = a;
        }

        //Behaviors 
        //Only setting the two local variables
        //Not the inherited ones.

        public void SetInstructorId(string id) { id = id; }
        public string GetInstructorId() { return id; }

        public void SetInstructorOffice(string office){ office = office; }
        public string GetInstructorOffice() { return office; }

        public void Display()
        {
            Console.WriteLine("Id is :" + id);
            Console.WriteLine("Instructor Office is : " + office);
            base.Display();//S how the inherited info.

        }






















    }//End Class
}//End Namespace
