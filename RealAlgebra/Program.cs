using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShaoeAreaLib;
namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the shape 1. Rectangle \t 2. Square\t 3. Circle\t 4. Triangle");

            int choice = int.Parse(Console.ReadLine());



            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Length and Breadth");
                        double length = double.Parse(Console.ReadLine());
                        double breadth = double.Parse(Console.ReadLine());

                        Rectangle rectangle = new Rectangle();
                        double area = rectangle.Area(length, breadth);
                        Console.WriteLine(area);
                        Console.WriteLine($"Area is :{area}" );
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Enter Length of Square");
                        double length = double.Parse(Console.ReadLine());

                        Square square = new Square();
                        Console.WriteLine($"Area is : { square.Area(length)}");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Enter Radius of Circle");
                        double radius = double.Parse(Console.ReadLine());

                        Circle circle = new Circle();
                        Console.WriteLine($"Area is : {circle.Area(radius)}");
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("Enter base and Height of Triangle");
                        double b = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());

                        Triangle triangle = new Triangle();
                        Console.WriteLine($"Area is :{triangle.Area(b, h)}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid input");
                        break;
                    }
            }
            Console.ReadKey();

        }
    }
}
