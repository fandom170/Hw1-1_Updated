using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    static class Comparing
    {
        public static String CompareFigures(Square square, Circle circle) {
            string result = "";
            double diag = square.side * (Math.Sqrt(2));
            double diam = circle.GetRadius() * 2.0;
            double r = circle.GetRadius();
            double side = square.side;
            if (2 * r < side) 
            {
                Console.WriteLine("Circle is fully inside square");
            } 
            else if (2 * r == side) 
            {
                Console.WriteLine("Diametr of circle is equal radius");
            }
            else if (diag == diam) 
            {
                Console.WriteLine("corners of circle match circle line");
            }
            else if (diam > diag) 
            {
                Console.WriteLine("circle is greater than square");
            }
            else 
            {
                Console.WriteLine("Circle crosses square");
            }
            
            

            return result;
        }
                
    }
}
