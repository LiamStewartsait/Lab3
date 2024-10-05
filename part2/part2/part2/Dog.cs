using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Dog : IAnimal
    {
        public Dog()
        {

        }
        private string _Name;
        public string Name { get => _Name; set => _Name = value; }

        private string _Colour;
        public string Colour { get => _Colour; set => _Colour = value; }

        private int _Age;
        public int Age { get => _Age; set => _Age = value; }

        public string Cry()
        {
            return "Woof!";
        }

        public void eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
    }
}
