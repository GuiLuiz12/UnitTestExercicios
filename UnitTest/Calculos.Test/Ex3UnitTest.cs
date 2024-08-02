using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class Ex3UnitTest
    {
        [Fact]
        public void Converter0Celsius()
        {
            var celsius = 0;
            var esperadoFahrenheit = 32;

            var result = Ex3.Celsius_Fahrenheit(celsius);

            Assert.Equal(esperadoFahrenheit, result, precision: 1);
        }

        [Fact]
        public void Converter100Celsius()
        {
            var celsius = 100;
            var esperadoFahrenheit = 212;

            var result = Ex3.Celsius_Fahrenheit(celsius);

            Assert.Equal(esperadoFahrenheit, result, precision: 1);
        }
    }
}
