using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    static class Comparing
    {
        public static String CompareFigures(Square square, Circle circle) {
            string result = "";
            if (circle.GetDiameter() < square.side) 
            {
                Console.WriteLine("Circle is fully inside square");
            } 
            else if (circle.GetDiameter() == square.side) 
            {
                Console.WriteLine("Diametr of circle is equal radius");
            }
            else if (square.diagonal == circle.GetDiameter()) 
            {
                Console.WriteLine("corners of circle match circle line");
            }
            else if (circle.GetDiameter() > square.diagonal) 
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
