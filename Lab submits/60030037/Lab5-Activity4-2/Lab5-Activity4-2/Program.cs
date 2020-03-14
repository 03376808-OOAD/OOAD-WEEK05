using System;

namespace Lab5_Activity4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingObject[] dObj = new DrawingObject[5];

            dObj[0] = new Line();
            dObj[1] = new Circle();
            dObj[2] = new Square();
            dObj[3] = new Rectangle();
            dObj[4] = new DrawingObject();

            foreach (DrawingObject drawObj in dObj)
            {
                drawObj.Draw();
            }

            Console.ReadKey();
        }
    }
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
            Console.WriteLine("I'm a Circle.");
        }
    }
    public class Line : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Line.");
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
            Console.WriteLine("I'm a rectangle");
        }
    }
}
