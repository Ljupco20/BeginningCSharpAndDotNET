using System;

namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken("Marko", 2);
            chicken.Age += 1;
            chicken.EatFood();
            chicken.Cluck();

            chicken = new Chicken();
            chicken.Name = "Goran";
            chicken.Age = 1;
            chicken.EatFood();
            chicken.Cluck();
        }
    }

    public class Chicken
    {
        public Chicken()
        {
            Name = default;
            Age = default;
        }

        public Chicken(string name, int age)
        {
            Name = name ?? "";
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public void EatFood()
        {
            Console.WriteLine($"{Name} is eating food!");
        }
        public void Breed()
        {
            Console.WriteLine($"{Name} is breeding");
        }
        public void Cluck()
        {
            Console.WriteLine($"{Name} is clucking");
        }
        public void LayEgg()
        {
            Console.WriteLine($"{Name} is laying eggs");
        }
    }
}
