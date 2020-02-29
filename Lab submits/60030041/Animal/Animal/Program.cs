using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eat...");
        }
    }
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meow");
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            Console.ReadKey();
        }
    }
}
