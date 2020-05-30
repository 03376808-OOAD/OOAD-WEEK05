using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Activiy4_2
{
    class Program
    {
        public class DrawingObject
        {
            public virtual void Draw()
            {
                Console.WriteLine("I'm just a generic drawing object.");
            }
        }
        public class Circle : DrawingObject
        {
            public override void Draw()
            {
                Console.WriteLine("I.m a Circle.");
            }
        }
        public class Line : DrawingObject
        {
            public override void Draw()
            {
                Console.WriteLine("I,m a Line.");
            }
        }
        public class Square : DrawingObject
        {
            public override void Draw()
            {
                Console.WriteLine("I'm a Square.");
            }
        }
        public class Rectangle : Square
        {
            public new void Draw()
            {
                Console.WriteLine("I'm a rectamgle.");
            }
        }
        public static int Main(string[] args)
        {
            DrawingObject[] aObj = new DrawingObject[5];
            aObj[0] = new Line();
            aObj[1] = new Circle();
            aObj[2] = new Square();
            aObj[3] = new Rectangle();
            aObj[4] = new DrawingObject();
            foreach (DrawingObject drawObj in aObj)
            {
                drawObj.Draw();

            }
            Console.ReadKey();
            return 0;

        }
    }
}
