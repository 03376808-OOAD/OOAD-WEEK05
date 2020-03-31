using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cdelegate_act1
{
    delegate void delehello();

    class Program
    {
        static void Main(string[] args)
        {
            delehello delH = hello;
            delH();Console.ReadKey();
        } 
        public static void hello()
        {
            Console.WriteLine("hrllo world.");
        }
    }
}
