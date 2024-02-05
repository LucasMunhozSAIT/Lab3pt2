using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3pt2
{
    public class Dog : IAnimal
    {
        //2.	Create a Dog class that implements the IAnimal interface.
        //The Eat method should print “Dogs eat meat” and the “Cry” method should print “Woof!”
        public string Name { get; set; }
        public string Color { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        
        public Dog()
        {

        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public string Cry()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return $"\nDog information:\n" +
                $"Name: {Name}.\n" +
                $"Color: {Color}.\n" +
                $"Age: {Age}.\n" +
                $"Height: {Height}.";
        }
    }
}
