﻿using System;

namespace Lab5_Activity3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass child = new ChildClass();
            child.print();

            Console.ReadKey();
        }
    }

    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Constructor.");
        }

        public void print()
        {
            Console.WriteLine("I'm a Parent Class.");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Child Constructor.");
        }
    }
}
