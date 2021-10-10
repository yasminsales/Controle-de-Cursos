using System;
using System.Collections.Generic;
using System.Text;

namespace Controle_de_Custos
{
    class Student : Person
    {
        private string Registration { get; set; }

        /// <summary>
        /// Valid situations:
        /// studying 
        /// locked
        /// graduated
        /// </summary>
        private string Situation { get; set; }

        public Student(string name, string address, string phone, string registration, string situation) : base(name, address, phone)
        {
            this.Registration = registration;
            this.Situation = situation;
        }
        public new string ToString()
        {
            return "Student: registration=" + Registration + "situation=" + Situation;
        }
        public void Lock()
        {
            if (Situation == "studying")
            {
                Situation = "locked";
                Console.WriteLine("Student locked the course");
            } else
            {
                Console.WriteLine("Student can't lock the course, he/she is not studying");
            }

        }

        public void Graduate()
        {
            if (Situation != "studying")
            {
                Console.WriteLine("Student cannot be graduated because he/she is not studying.");
                return;
            }
            Situation = "graduated";
            Console.WriteLine("Student graduated the course");
        }

        public void Enroll()
        {
            if (string.IsNullOrWhiteSpace(Registration))
            {
                Console.WriteLine("Student needs to register before enrolling a course.");
                return;
            }
        }
    }

}
