/************************************
 *  Author : Robert McGuire
 *  Description : Lab 2 Business Classes
 *  Course : C# 2 Programming 
 *  Form 1
 * **************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddressBtnClicked_Click(object sender, EventArgs e)
        {
            Address a1;
            a1 = new Address("StreetName-0032", "City-87", "State-098", 30114);//Just For testing. 
            a1.Display();
        }//End AddressBtn Cicked

        private void CourseBtnClicked_Click(object sender, EventArgs e)
        {
            Course c1;
            c1 = new Course("CTC123", "C#2 Programming", "Advanced Object...", 4.0);
            c1.Display();
        }//End Course Btn Clicked

        private void SectionBtnClicked_Click(object sender, EventArgs e)
        {
            Section s1;
            s1 = new Section("CTC123", "C2923", "Monday-Wednesday-Friday", "F-1149", 1);
            s1.Display();
        }//End Section Btn Clicked

        private void PersonBtnClicked_Click(object sender, EventArgs e)
        {
            Person p1;
            p1 = new Person("Rob", "Mac", "email@email.com", new Address("179 west 3rd. Street","Clifton", "NJ", 07011));
            p1.Display();
        }//End Person Btn Clicked

        private void StudentBtnClicked_Click(object sender, EventArgs e)
        {
            Student stu1;
            stu1 = new Student("CTC-123", 3.0, "robert", "McGuire", "Email@email.com", new Address("179 west 3rd. Street", "Clifton", "NJ", 07011));
            stu1.Display();
        }//End Stdent Btn Clicked

        private void InstructorBtnClicked_Click(object sender, EventArgs e)
        {
            Instructor i2;
            i2 = new Instructor("CTC-123", "F-1149", "Ron", "Enz", "email@email.com", new Address("179 west 3rd. Street", "Clifton", "NJ", 07011));
            i2.Display();
        }

        private void ScheduleBtnClicked_Click(object sender, EventArgs e)
        {

        }
    }//End Class Form1
 }//End Namespace
