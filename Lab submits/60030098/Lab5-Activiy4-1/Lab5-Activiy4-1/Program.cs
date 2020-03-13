using System;

namespace Lab5_Activiy4_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1. สร้างอาร์เรย์ของออปเจกต์ของ base class มีพื้นที่เก็บ 4 ออปเจ็กต์ 
            DrawingObject[] dObj = new DrawingObject[4];


            // 1. สร้างออปเจกต์จาก derived class แต่ละตัวแล้วเก็บ reference ในอาร์เรย์ 
            dObj[0] = new Line();
            dObj[1] = new Circle();
            dObj[2] = new Square();
            dObj[3] = new DrawingObject();

            // วนลูปเพื่อเรียกเมธอดในแต่ละออปเจ็กต์
            foreach (DrawingObject drawObj in dObj)
            {
                drawObj.Draw();
            }

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
}
