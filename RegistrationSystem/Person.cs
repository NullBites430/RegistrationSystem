/************************************
 *  Author : Robert McGuire
 *  Description : Lab 3 Inheritance
 *  Course : C# 2 Programming 
 *  Person class "SuperClass"
 * **************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Person
    {
        //====== Properties ===========
        private string fname;
        private string lname;
        private string email;
        private string address;

        //======= Constructors ========
        public Person()
        {
            fname = "";
            lname = "";
            email = "";
            address = "";
        }

        public Person(string tFn, string tLn, string tE, string tA)
        {
            fname = tFn;
            lname = tLn;
            email = tE;
            address = tA;
        }//====== End Constructor Section.======== 

        //=========== Behaviors ==================

        //=== Setter & Getter Section. ===========
        public void SetFirstName(string tFn)
        {
            fname = tFn;
        }
        public string GetFirstName()
        {
            return fname;
        }
        public void SetLastName(string tLn)
        {
            lname = tLn;
        }
        public string GetLastName()
        {
            return lname;
        }
        public void SetEmail(string tE)
        {
            email = tE;
        }
        public string GetEmail()
        {
            return email;
        }

        public void SetAddress(string tA)
        {
            address = tA;
        }
        public string GetAddress()
        {
            return address;
        }
        //===== End Setter & Getter Section =====

        public void Display()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("****  Person Display  ********");
            Console.WriteLine("                              ");
            Console.WriteLine("First Name is: ");//Add the method or value for the name.
            Console.WriteLine("Last Name is: ");//Add the method or value for the name.
            Console.WriteLine("Email is: ");//Add the method or value for the name.
            Console.WriteLine("Address is : ");//Add the method or value for the name.
        }//End display

    }//End Class
}//End Namespace
