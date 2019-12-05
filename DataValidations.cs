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
            double value = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter main characteristic parameter of {0}", nameVal);
                String value0 = Console.ReadLine();

                double.TryParse(value0, out value);
                if (double.IsNaN(value) || double.IsInfinity(value))
                {
                    Console.WriteLine("Incorrect parameter for {0} was entered", nameVal);
                    continue;
                }

                break;
            }

            value = Math.Round(value * 100d) / 100;

            if (value <= 0 )
            {
                Console.WriteLine("Wrong or zero data was entered. Characteristic parameter will be set randomly");
                Random r = new Random();
                value = Math.Round((r.NextDouble() * (5.0 - 0.5) + 0.5) * 100d) / 100d;
                
            }

            return value;
        }
    }
}
