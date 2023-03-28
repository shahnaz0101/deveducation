using System.Runtime.CompilerServices;

namespace ConsoleApp133
{    
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.CalculateArea();
            Convert.ToInt32(Console.ReadLine());
        }
    }
    public class Shape
    {
        public double Area { get; set; }
    }

    public class Rectangle : Shape
    {
        
        public int Length {get; set; }
        public int Width { get; set; }
        public void CalculateArea()
        {
            Area = Length  * Width;
        }
    }
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public void CalculateArea()
        {
            Area = Math.PI * Radius;
        }
    }
    public class Trapezoid : Shape
    {
        public int Length1 { get; set; }
        public int Length2 { get; set; }
        public int Height { get; set; }
        public void CalculateArea()
        {
            Area = (Length1 + Length2) / 2* Height ;
        }
    }

    public class Animal
    {
             
    }

    public class Owl
    {    
        public void makeSound()
        {
          
        }
    }
}