using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Cats : IAnimal
    {
        public Cats()
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
            return "Meow!";
        }

        public void eat()
        {
            Console.WriteLine("Cat eats mice");
        }
    }
}
