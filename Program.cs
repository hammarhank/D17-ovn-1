using System;
namespace D17_ovn_1
{
    internal class Program
    {
        public class Rectangle
        {
            private double Width, Length;

            public Rectangle(double w, double l)
            {
                this.Width = w;
                this.Length = l;
            }
            public void Print()
            {
                Console.WriteLine($"Width: {Width}\nLength: {length}");
            }
            public double Area()
            {


                return width * length;
            }
            public double length { get; set;}
            public double width { get; set;}
            //C#1.1
            /*       public double width
                  {
                      get { return Width; }
                      set { Width = value; }
                  }
                  public double length
                  {
                      get { return Length; }
                      set { Length = value; }
                  }

                    public double GetWidth()
                     {return Width; }
                     public double GetLength()
                     { return length; }
                     public void SetWidth(double newWidth)
                     {
                         Width = newWidth;
                     }
                     public void SetLength(double newLength)
                     {
                         length = newLength;
                     }*/
        }


        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(1.3, 4.2);
            r.Print();
            Console.WriteLine(r.Area());
            r.width = 10;
            r.length = 10;
            /*     Console.WriteLine(r.GetWidth());
                 Console.WriteLine(r.GetLength());
                 Console.WriteLine("========================");
                 r.SetWidth(5.0);
                 r.SetLength(5.0);
                 Console.WriteLine($"Width: {r.GetWidth()}");
                 Console.WriteLine($"Length: {r.GetLength()}");*/
            Console.WriteLine($"Width: {r.width}");
            Console.WriteLine($"Length: {r.length}");
            Console.WriteLine($"Area: {r.Area()}");
        }
    }
}