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
            //Console.Clear();
            double value = 0;
            Boolean valid = false;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter main characteristic parameter of {0}", nameVal);
                valid = double.TryParse(Console.ReadLine(), out value);
                if (!valid)
                {
                    Console.WriteLine("Incorrect parameter for {0} was entered", nameVal);
                    continue;
                }

                if (value <= 0) 
                {
                    Console.WriteLine("Zero or negative data was entered. Please try again");
                    continue;
                }
                break;
            }

            if (value <= 0)
            {
                Console.WriteLine("Wrong or zero data was entered. Characteristic parameter will be set randomly");
                Random r = new Random();
                value = Math.Round((r.NextDouble() * (5.0 - 0.5) + 0.5), 2);
                Console.WriteLine("new value is {0}", value);
             }

            return value;
        }
    }
}
