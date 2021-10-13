using System;
using System.Collections.Generic;
using System.Text;

namespace Controle_de_Custos
{
    class Subject
    {
        public int SubjectCode { get; set; }
        public int WorkLoad { get; set; }
        public string SubjectDescription { get; set; }
        public void SubjectRegister()
        {
            Console.WriteLine("New discipline? Register here.");
            SubjectCode = int.Parse(Console.ReadLine());

        }
    }
}



