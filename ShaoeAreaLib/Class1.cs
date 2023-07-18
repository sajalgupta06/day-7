using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaoeAreaLib
{

    public class Rectangle
    {

        public double Area(double x, double y)
        {
            double area = x * y;
            
            return area;
        }
    }

    public class Square
    {

        public double Area(double x)
        {
            return x * x;
        }
    }

    public class Circle
    {

        public double Area(double r)
        {
            return Math.PI * r*r;
        }
    }


    public class Triangle
    {

        public double Area(double b, double h)
        {
            return b * h*0.5;
        }
    }


    public class Class1
    {

       
    }
}
