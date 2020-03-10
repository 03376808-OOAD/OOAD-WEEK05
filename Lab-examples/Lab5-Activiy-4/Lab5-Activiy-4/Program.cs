using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Activiy_4
{
    class Program
    {
        public static int Main()
        {

            // 1. สร้างอาร์เรย์ของออปเจกต์ของ base class มีพื้นที่เก็บ 4 ออปเจ็กต์ 
            DrawingObject[] dObj = new DrawingObject[5];


            // 1. สร้างออปเจกต์จาก derived class แต่ละตัวแล้วเก็บ reference ในอาร์เรย์ 
            dObj[0] = new Line();
            dObj[1] = new Circle();
            dObj[2] = new Square();
            dObj[3] = new Rectangle();
            dObj[4] = new DrawingObject();

            // วนลูปเพื่อเรียกเมธอดในแต่ละออปเจ็กต์
            foreach (DrawingObject drawObj in dObj)
            {
                drawObj.Draw();
            }

            return 0;
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

    public class Square : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Square.");
        }
    }


    public class Rectangle: Square
    {
        public new void Draw()
        {
            Console.WriteLine("I'm a rectangle.");
        }
    }




    public class Line : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Line.");
        }
    }


}
