using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3
{
    internal class Cat : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
        public Cat(String name, String colour, int age)
            : base(name, colour, age) { }
    }
}
