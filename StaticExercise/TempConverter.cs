using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempInFahrenheit)
        {
            //C = (F - 32) * 5 / 9;
            return (tempInFahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double tempInCelsius)
        {
            // F = (C * 9) / 5 + 32;
            return (tempInCelsius * 9) / 5 + 32;
        }
    }
}
