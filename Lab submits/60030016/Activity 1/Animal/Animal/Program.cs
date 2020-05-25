using System;

namespace Animal
{
    class Animal            // เพิ่ม class ชื่อ  Animal
    {
        public void Eat()   // เมธอด Eat()
        {
            // ยังไม่ต้องเขียน Code
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
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}
