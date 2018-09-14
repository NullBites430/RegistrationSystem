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
        //private string address;
        public Address a1 = new Address();
        //======= Constructors ========
        public Person(){  }//<--- Default

        public Person(string tFn, string tLn, string tE, Address a)//<-- Accepting an Object.
        {
            fname = tFn;
            lname = tLn;
            email = tE;
            a1 = a;
            
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

        public void SetAddress(Address a)
        {
            a1 = a;
        }
        public Address GetAddress()
        {
            return a1;
        }
        //===== End Setter & Getter Section =====

        public void Display()
        {
            Console.WriteLine("First Name is: "+ fname);//Add the method or value for the name.
            Console.WriteLine("Last Name is: "+ lname);//Add the method or value for the name.
            Console.WriteLine("Email is: "+ email);//Add the method or value for the name.
            a1.Display();//Calls the Address Object's Display Method.
        }//End display

    }//End Class
}//End Namespace
