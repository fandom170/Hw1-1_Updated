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
                result = "Circle is fully inside square";
            } 
            else if (circle.GetDiameter() == square.side) 
            {
                result = "Diametr of circle is equal radius";
            }
            else if (square.diagonal == circle.GetDiameter()) 
            {
                result = "Corners of circle match circle line";
            }
            else if (circle.GetDiameter() > square.diagonal) 
            {
                result = "Circle is greater than square";
            }
            else 
            {
                result = "Circle crosses square";
            }
             return result;
        }
                
    }
}
