using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal            // เพิ่ม class ชื่อ  Animal
    {
        public void Eat()   // เมธอด Eat()
        {
        }
    }
    class Cat : Animal
    {
        public void Meow()
        {

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
            Animal animal = new Animal();   // สร้างออปเจ็กต์ animal
            animal.Eat();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}