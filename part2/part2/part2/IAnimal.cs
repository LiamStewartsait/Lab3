using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal interface IAnimal
    {
        public string Name
        {
            get;
            set;
        }


        public string Colour { get; set; }
        public int Age { get; set; }

        public abstract void eat();

        public string Cry();
    }
}
