

namespace Lab3
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("give the dog a name");
            String x = Console.ReadLine();

            Dog dog = new Dog(x,"black",5);

            Console.WriteLine("The dogs name is "+ dog.getName());
            Console.WriteLine("The dogs colour is " + dog.getColour());
            Console.WriteLine("The dogs age is " + dog.getAge());
            dog.eat();

            Console.WriteLine("give the cat a name");
            x = Console.ReadLine();

            Cat cat = new Cat(x, "gray", 7);

            Console.WriteLine("The cats name is " + cat.getName());
            Console.WriteLine("The cats colour is " + cat.getColour());
            Console.WriteLine("The cats age is " + cat.getAge());
            cat.eat();

        }
    }
}