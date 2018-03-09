using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializers
{
    class Program
    {
        static void Main(string[] args)
        {
            // uses an object initializer to avoid multuple constructors
            var person = new Person
            {
                id = 1,
                name = "Enrico"
            };
        }
    }

    public class Person
    {
        public int id;
        public string name; 
    }
}
