using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
           // Dog dog = new Dog();
           Puppy puppy = new Puppy();
           // Cat cat = new Cat();
            //Animal animal = new Animal();
            //dog.Bark();
           puppy.Bark();
           puppy.Eat();
            puppy.Weep();
           //animal.Eat();
           //cat.Eat();
           // cat.Meow();

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

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Moew...");
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
