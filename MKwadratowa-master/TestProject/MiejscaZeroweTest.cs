using MKwadratowa;
using System;
using Xunit;

namespace TestProject
{
    public class MiejscaZeroweTest
    {
        [Fact]
        public void ObliczBrakMiejscZerowychPodaneDaneTest()
        {
            MiejscaZerowe mz = new MiejscaZerowe();

            (double, double) x0 = mz.Oblicz(5, 4, 1);

            Assert.Equal(x0.Item1, double.NaN);
            Assert.Equal(x0.Item2, double.NaN);
        }

        [Theory]
        [InlineData(3, 3, 1)]
        [InlineData(5, 1, 1)]
        [InlineData(10.5, 5, 9.2)]
        [InlineData(1, 0, 1)]
        public void ObliczBrakMiejscZerowychZestawDanychTest(double a, double b, double c)
        {
            MiejscaZerowe mz = new MiejscaZerowe();

            (double, double) x0 = mz.Oblicz(a, b, c);

            Assert.Equal(x0.Item1, double.NaN);
            Assert.Equal(x0.Item2, double.NaN);
        }


        [Theory]
        [InlineData(4, 4, 1, -0.5)]
        [InlineData(4.5, 6, 2, -0.667)]
        [InlineData(0,0,0,double.NaN)]
        public void ObliczJednoMiejsceZeroweZestawDanychTest(double a, double b, double c, double xe)
        {
            MiejscaZerowe mz = new MiejscaZerowe();

            (double, double) x0 = mz.Oblicz(a, b, c);

            Assert.Equal(x0.Item1, x0.Item2, 3);
            Assert.Equal(x0.Item1, xe, 3);
            Assert.Equal(x0.Item2, xe, 3);
        }

        [Theory]
        [InlineData(4, 5, 1,-1,-0.25)]
        [InlineData(3.2, 12.1, 1.5,-3.653, -0.128)]
        [InlineData(4, 5.5, 1.1 , -1.132, -0.243)]
        public void ObliczDwaMiejsceZeroweZestawDanychTest(double a, double b, double c, double x1, double x2)
        {
            MiejscaZerowe mz = new MiejscaZerowe();

            (double, double) x0 = mz.Oblicz(a, b, c);

            Assert.Equal(x0.Item1, x1, 3);
            Assert.Equal(x0.Item2, x2, 3);
        }






    }
}
