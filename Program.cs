using System.Xml.Linq;

namespace Lab3pt2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //4.	To test the program, ask the user for a dog name and create a new Dog type object from the Main of the program.
            //Then ask the user to give the Dog object a name, height, colour and age, and then execute the getter methods to print 
            //these properties and run the Eat and Cry methods.

            //Dog
            Console.WriteLine("Hello!!!\n" +
                "Please enter the dog name: ");
            string dogName = Console.ReadLine();

            Dog inputDog = new Dog
            {
                Name = dogName
            };

            Console.WriteLine($"Please enter the height of {dogName}: ");   
            inputDog.Height = double.Parse( Console.ReadLine() );

            Console.WriteLine($"Please now, enter the color of {dogName}: ");
            inputDog.Color = Console.ReadLine();

            Console.WriteLine($"Enter the age of {dogName}: ");
            inputDog.Age = int.Parse(Console.ReadLine());


            Console.WriteLine(inputDog.ToString());
            inputDog.Eat();
            Console.WriteLine($"Cry: {inputDog.Cry()}\n");


            //5.	Repeat the previous step for a Cat object.
            //Cat
            Console.WriteLine("Hello!!!\n" +
                "Please enter the cat name: ");
            string catName = Console.ReadLine();

            Cat inputCat = new Cat
            {
                Name = catName
            };

            Console.WriteLine($"Please enter the height of {catName}: ");
            inputCat.Height = double.Parse(Console.ReadLine());

            Console.WriteLine($"Please now, enter the color of {catName}: ");
            inputCat.Color = Console.ReadLine();

            Console.WriteLine($"Enter the age of {catName}: ");
            inputCat.Age = int.Parse(Console.ReadLine());

            Console.WriteLine(inputDog.ToString());
            inputCat.Eat();
            Console.WriteLine($"Cry: {inputCat.Cry()}\n");

            
            //6.	Create a list called “animals” and add some animal objects to the list. 
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add( inputDog );
            animals.Add( inputCat );

            //7.	Print the names of all the animals.
            Console.WriteLine("List of animals:");
            foreach ( IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }


        }
    }
}
