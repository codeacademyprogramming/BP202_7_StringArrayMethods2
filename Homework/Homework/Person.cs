using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Person
    {
        public Person(string name,string surname,byte age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age; 
        }
        public string Name;
        public string Surname;
        public byte Age;
    }
}
