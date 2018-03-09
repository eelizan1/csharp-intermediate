using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            var p = Person.Parse("Enrico");
            p.Introduce("Mosh");
            Console.Read(); 
        }
    }

    public class Person
    {
        public string Name; 

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, this.Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    
}
