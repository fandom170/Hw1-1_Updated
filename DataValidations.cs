using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class DataValidations 
    {
        public double GetValue(string nameVal)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter side of square");
                String side0 = Console.ReadLine();
                Console.WriteLine("Please enter radius of circle");
                String radius0 = Console.ReadLine();

                double.TryParse(side0, out side);
                if (double.IsNaN(side) || double.IsInfinity(side))
                {
                    Console.WriteLine("Incorrect value of square side was entered");
                    continue;
                }

                double.TryParse(radius0, out radius);
                if (double.IsNaN(radius) || double.IsInfinity(radius))
                {
                    Console.WriteLine("Incorrect value of radius was entered");
                    continue;
                }

                break;
            }

            if (radius <= 0 || side <= 0)
            {
                Console.WriteLine("Wrong or zero data was entered. Square side and radius will be set randomly");
                Random r = new Random();
                radius = Math.Round((r.NextDouble() * (5.0 - 0.5) + 0.5) * 100d) / 100d;
                side = Math.Round((r.NextDouble() * (5.0 - 0.5) + 0.5) * 100d) / 100d;
            }
        }
    }
}
