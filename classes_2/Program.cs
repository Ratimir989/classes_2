using System;

namespace classes_2
{
    class Rectangle
    {
        private double side1 { get; set; }
        private double side2 { get; set; }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator(double side1, double side2)
        {
            double area = side1 * side2;
            return area;
        }
        public double PerimeterCalculator(double side1, double side2)
        {
            return (side1 + side2) * 2;
        }
        public double Area { get; }

        public double Perimeter { get; }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строны прямоугольника");
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle( side1,  side2);
            Console.WriteLine($"площадь прямоугольника равна {rectangle.AreaCalculator()}");
            
        }
    }
}
