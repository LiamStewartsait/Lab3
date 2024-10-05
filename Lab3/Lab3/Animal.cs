using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal abstract class Animal
    {
        String name;
        String colour;
        int age;

        public String getName() { return this.name; }
        public String getColour() { return this.colour; }
        public int getAge() { return this.age; }

        public void setName(String name) { this.name = name;}
        public void setColour(String colour) {  this.colour = colour;}
        public void setAge(int age) {  this.age = age;}

        public abstract void eat();

        public Animal()
        {
            this.name = string.Empty;
            this.colour = string.Empty;
            this.age = 0;
        }
        public Animal(String name,String colour, int age)
        {
            this.name = name;
            this.colour = colour;
            this.age = age;
        }

    }
}
