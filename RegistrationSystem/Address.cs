/************************************
 *  Author : Robert McGuire
 *  Description : Lab 2 Business Classes
 *  Course : C# 2 Programming 
 *  Address Class
 * **************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationSystem
{
    class Address
    {
        //Properties 
        private string streetName;
        private string city;
        private string state;
        private int zip;


        //-------------Default constructor----------//
        public Address()
        {
            streetName = "";
            city = "";
            state = "";
            zip = 00000;
        }

        //-------------All Argument Constructor-----//
        public Address(string tempStreetName, string tempCity, string tempState, int tempZip)
        {
            streetName = tempStreetName;
            city = tempCity;
            state = tempState;
            zip = tempZip;
        }
        //Behaviors 

        //-------------- Street ------------------//
        public void SetStreet(string tempStreetName)
        {
            streetName = tempStreetName;
        }//End Set

        public string GetStreet()
        {
            return streetName;
        }//End Get

        //--------------- City -------------------//
        public void SetCity(string tempCity)
        {
            city = tempCity;
        }//End Set

        public string GetCity()
        {
            return city;
        }//End Get

        //-------------- State ---------------------//

        public void SetState(string tempState)
        {
            state = tempState;
        }//End Set

        public string GetState()
        {
            return state;
        }//End Get

        //----------- Zip --------------------------//
        public void SetZip(int tempZip)
        {
            zip = tempZip;
        }//End Set

        public int GetZip()
        {
            return zip;
        }//End Get

        public void Display()
        {
            Console.WriteLine("Street: " + streetName);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("ZipCode: " + zip);
        }//End Display
    }//End Class
}//End Namespace

