﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Circle
    {
        private double radius;

        public Circle(double radius) {
            this.radius = radius;
        }


        public double GetArea() {
            return (Math.Round(radius * radius * Constants.pi*100d))/100;
        }

        public double GetRadius() 
        {
            return radius;
        }

        public double GetDiameter() 
        {
            return (Math.Round(radius * 2 * 100d))/100;
        }

        
    }
}
