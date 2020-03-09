using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Activity3
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass child = new ChildClass();

            child.print();
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
