using System;

namespace Controle_de_Custos
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Natalia", "Avenida Interlagos", "99599-8888"); 
            Console.WriteLine("person1 Name = {0} Age = {1}", p1.Name, p1.Address, p1.Phone);
            Console.WriteLine(p1);
        }
    }
}
