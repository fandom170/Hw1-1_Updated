using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Square
    {
        public Square(double side) {
            this._side = side;
        }

        private double _side;

        public double area 
        {
            get 
            {
                return Math.Round((Math.Pow(_side, 2.0)*100d))/100d;
            }
          }

        public double side 
        {
            get {return _side;}
        }

        public double diagonal 
        {
            get { return _side * Math.Sqrt(2); }
        }


    }

    
}
