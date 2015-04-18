using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Frog[] frogs = 
            {
                new Frog (2, "tryn", 'f'),
                new Frog (8, "mryn", 'f'),
                new Frog (6, "zwyn", 'f'),
                new Frog (7, "lqlq", 'f'),

            };
            Dog[] dogs =
            {
                new Dog( 4, "Doggy", 'f'),
                new Dog( 7, "charly", 'f'),
                new Dog( 8, "Tot", 'f'),
                new Dog( 10, "Sparki", 'f')
            };
            Cat[] cats =
            {
                new Kitten( 3, "Tomas"),
                new TomCat( 5, "Age"),
                new Kitten( 2, "Mila"),
                new TomCat( 1, "Miss")
            };
            dogs[2].IdentifyAnimal();
            cats[1].IdentifyAnimal();
            frogs[3].ProduceSound();

            Console.WriteLine("Average age of dogs " + Animal.Average(dogs));
            Console.WriteLine("Average age of frogs " + Animal.Average(frogs));
            Console.WriteLine("Average age of cats " + Animal.Average(cats));
        }
    }
}
