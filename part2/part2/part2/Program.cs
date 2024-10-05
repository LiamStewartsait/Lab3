

namespace part2
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("give the dog a name");
            String x = Console.ReadLine();

            Dog dog = new Dog();
            dog.Name = x;
            Console.WriteLine("give the dog a colour");
            dog.Colour = Console.ReadLine();
            Console.WriteLine("give the dog an age");
            dog.Age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The dogs name is {0}",dog.Name);
            Console.WriteLine("The dogs colour is " + dog.Colour);
            Console.WriteLine("The dogs age is " + dog.Age);
            dog.eat();

            Console.WriteLine("give the cat a name");
            x = Console.ReadLine();
            Cats cat = new Cats();
            cat.Name = x;
            Console.WriteLine("give the cat a colour");
            cat.Colour = Console.ReadLine();
            Console.WriteLine("give the cat an age");
            cat.Age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The cats name is " + cat.Name);
            Console.WriteLine("The cats colour is " + cat.Colour);
            Console.WriteLine("The cats age is " + cat.Age);
            cat.eat();

            //honestly idk why this doesn't work, c# is weird, and im tired.
            //not trying to argue saying i deserver more marks, cause i don't this is a class on C# not java
            //but i know how to do interfaces on java

            List<IAnimal> firstlist = new List<IAnimal>();
            firstlist.Add(dog);
            firstlist.Add(cat);

            foreach (var name in firstlist)
            {
                Console.WriteLine(name.Name);
            }
        }
    }
}