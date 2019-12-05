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
            string form;
            form = "Circle";
            Circle cr = new Circle(dt.GetValue(form));
            form = "Square";
            Square sq = new Square(dt.GetValue(form));

            Console.WriteLine("Current diametr of circle is: {0}", cr.GetDiam());
            Console.WriteLine("Current square side is {0}", sq.side);

            Console.WriteLine("Area of circle with radius {0} is: {1}", cr.GetRadius(), cr.GetArea());
            Console.WriteLine("Area of square with side size {0} is: {1}", sq.side, sq.area);

            Console.WriteLine(Comparing.CompareFigures(sq, cr));
        }
    }
}
