using System;
using System.Collections.Generic;
using System.Text;

namespace Controle_de_Custos
{
    class Teacher : Person
    {
        public string Education { get; set;  }

        public Teacher(string name, string address, string phone, string education) : base()
        {
            Education = education;
        }
        public new string ToString()
        {
            return "Teacher: Name=" + Name + "Address=" + Address + "Phone=" + Phone + "education=" + Education;
        }
    }
}
