using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMasking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Puppy puppy = new Puppy();
            dog.Bark();
            puppy.Bark();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("dog big barking...");
        }  
    }

    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("weeping...");
        }

        new public void Bark()
        {
            Console.WriteLine("puppy small bark...");
        }
    }
}
