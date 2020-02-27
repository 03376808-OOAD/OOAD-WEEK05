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
            Console.WriteLine("I am animal,I can eat.");
        }
    }
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("I am cat,I can Meow.");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("dog big barking....");
        }
    }
    class Puppy : Dog 
    {
        public void Weep()
        {
            Console.WriteLine("Weeping...");
        }
    }
    class Program
    {
        static void Main(string[]args)
        {

            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            Console.ReadLine();
        }
    }
  
}
