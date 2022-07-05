using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{

  

    public interface shape
    {
         double getArea();
         double GetPerimeter();
    }
    class rectangle : shape
    {
        public int length { get; set; }
        public int width { get; set; }
        double Area,Perimeter;
        

        public double getArea()
        {
            Area = length * width;
            return Area;
           
            throw new NotImplementedException();
        }

        public double GetPerimeter()
        {
           Perimeter=2*(length*width);
            return Perimeter;
            throw new NotImplementedException();
        }
    }
    class Circles : shape
        {
            static double PI = 3.14;
        double area;
        double perimeter;
         public int radius{ get; set; }
        public double getArea()
        {
            area=PI*radius;
            return area;
        }

        public double GetPerimeter()
        {
            perimeter=2*PI*radius;
            return perimeter;   
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Circles c = new Circles { radius = 20 };
            Console.WriteLine("area of circle; "+c.getArea());
            Console.WriteLine();
            Console.WriteLine("perimeter of area"+ c.GetPerimeter());
            Console.WriteLine();
            rectangle r=new rectangle { length = 10, width = 10 };
            Console.WriteLine("area of rectangle; "+ r.getArea());
            Console.WriteLine();
            Console.WriteLine("perimeter of rectangle;" + r.GetPerimeter());
            Console.WriteLine();


        }
    }
}
