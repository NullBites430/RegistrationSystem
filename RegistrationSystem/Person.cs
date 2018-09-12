/************************************
 * 
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

namespace StudentRegistrationSystem
{
    class Person
    {
        //====== Properties ===========
        private String fname;
        private String lname;
        private String email;
        private String address;

        //======= Constructors ========
        public Person()
        {

            fname = "";
            lname = "";
            email = "";
            address = "";
        }

        public Person(String tFn, String tLn, String tE, String tA)
        {
            fname = tFn;
            lname = tLn;
            email = tE;
            address = tA;
        }//====== End Constructor Section.======== 

        //=========== Behaviors ==================

        //=== Setter & Getter Section. ===========
        public void SetFirstName(String tFn)
        {
            fname = tFn;
        }
        public String GetFirstName()
        {
            return fname;
        }
        public void SetLastName(String tLn)
        {
            lname = tLn;
        }
        public String GetLastName()
        {
            return lname;
        }
        public void SetEmail(String tE)
        {
            email = tE;
        }
        public String GetEmail()
        {
            return email;
        }

        public void SetAddress(String tA)
        {
            address = tA;
        }
        public String GetAddress()
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
