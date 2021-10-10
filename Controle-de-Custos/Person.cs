using System;

public class Person
{

    public String Name { get; set; }
    public String Address { get; set; }
    public String Phone { get; set; }

    public Person(string name, string address, string phone)
    {
        this.Name = name;
        this.Address = address;
        this.Phone = phone; 
    }

    public Person()
    {
    }

    public string toString()
    {
        return "Person [name=" + Name + ", Address=" + Address + ", phone=" + Phone + "]";
    }

   
}

