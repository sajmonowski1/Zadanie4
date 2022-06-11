using System;

namespace MKwadratowa
{
    public class Program
    {
        static void Main(string[] args)
        {
            MiejscaZerowe mz = new MiejscaZerowe();

            Console.WriteLine(mz.Oblicz(-1, 3, 4));

            Console.WriteLine(mz.Oblicz(4, 4, 1));
            Console.WriteLine(mz.Oblicz(4.5, 6, 2));

            Console.WriteLine("dwaaa");

            Console.WriteLine(mz.Oblicz(4, 5, 1));
            Console.WriteLine(mz.Oblicz(3.2, 12.1, 1.5));
            Console.WriteLine(mz.Oblicz(4, 5.5, 1.1));
        }
    }
}
