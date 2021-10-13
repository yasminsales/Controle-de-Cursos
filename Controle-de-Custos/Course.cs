using System;

using System.Collections.Generic;
using System.Text;

namespace Controle_de_Custos
{
    class Course
    {
        private int CourseCode { get; set; }
        public string Description { get; set; }

        public void Register()
        {
            Console.WriteLine("New course? Register here.");
            CourseCode = int.Parse(Console.ReadLine());
           
        }
    }

}
