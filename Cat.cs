using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3pt2
{
    public class Cat : IAnimal
    {
        //3.	Create a Cat class that implements the above IAnimal interface.
        //The Eat method should print “Cats eat mice” and the “Cry” method should print “Meow!”
        public string Name { get; set; }
        public string Color { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public Cat()
        {

        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        public string Cry()
        {
            return "Meow!";
        }

        public override string ToString()
        {
            return $"\nCat information:\n" +
                $"Name: {Name}.\n" +
                $"Color: {Color}.\n" +
                $"Age: {Age}.\n" +
                $"Height: {Height}.";
        }
    }
}
