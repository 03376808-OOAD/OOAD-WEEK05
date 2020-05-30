using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Activiy4_1
{
    class Program
    {
        public static int Main()
        {
            DrawingObject[] dObj = new DrawingObject[4];

            dObj[0] = new Line();
            dObj[1] = new Circle();
            dObj[2] = new Square();
            dObj[3] = new DrawingObject();

            foreach (DrawingObject drawObj in dObj)
            {
                drawObj.Draw();
            }

            return 0;
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
    }
}
