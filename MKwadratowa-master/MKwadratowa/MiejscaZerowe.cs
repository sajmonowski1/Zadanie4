using System;
using System.Collections.Generic;
using System.Text;

namespace MKwadratowa
{
    public class MiejscaZerowe
    {
        public (double,double) Oblicz(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if(delta < 0)
            {
                Console.WriteLine("Brak miejsc zerowych.");
                return (double.NaN, double.NaN);
            }
            else if(delta == 0)
            {
                double x = -b / (2.0 * a);

                return (x, x);
            }
            else
            {
                double x1 = (-b - Math.Sqrt(delta))/ (2.0 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2.0 * a);

                return (x1, x2);
            }
        }
    }
}
