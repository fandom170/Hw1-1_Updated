using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DataValidations dt = new DataValidations();
            string form = "Circle";
            Circle circle = new Circle(dt.GetValue(form));
            form = "Square";
            Square square = new Square(dt.GetValue(form));

            Console.WriteLine("Current diametr of circle is: {0}", circle.GetDiameter());
            Console.WriteLine("Current square side is {0}", square.side);

            Console.WriteLine("Area of circle with radius {0} is: {1}", circle.GetRadius(), circle.GetArea());
            Console.WriteLine("Area of square with side size {0} is: {1}", square.side, square.area);

            Console.WriteLine(Comparing.CompareFigures(square, circle));
        }
    }
}
