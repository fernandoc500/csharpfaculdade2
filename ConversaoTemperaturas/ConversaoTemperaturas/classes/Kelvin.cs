using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperaturas
{
    class Kelvin : Temperatura
    {
        public Kelvin (double temp)
        {
            this.temp = temp;
        }

        public double ToCelsius()
        {
            return this.temp - 273.15;
        }

        public double ToFahrenheit()
        {
            Celsius c = new Celsius(this.ToCelsius());
            return c.ToFahrenheit();
        }

        public double ToRankine()
        {
            return this.temp * 1.8;
        }

        public double ToReaumur()
        {
            Celsius c = new Celsius(this.ToCelsius());
            return c.ToReaumur();
        }
    }
}
