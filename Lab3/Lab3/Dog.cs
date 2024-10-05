using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
        public Dog(String name, String colour, int age)
            : base(name, colour, age) { }

       
    }
}
