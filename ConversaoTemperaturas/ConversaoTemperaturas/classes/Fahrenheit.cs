using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperaturas
{
    class Fahrenheit : Temperatura
    {
        public Fahrenheit(double temp)
        {
            this.temp = temp;
        }

        public double ToCelsius()
        {
            return (this.temp - 32) + 5 / 9;
        }

        public double ToKelvin()
        {
            Celsius c = new Celsius(this.ToCelsius());
            return c.ToKelvin();
        }

        public double ToRankine()
        {
            Celsius c = new Celsius(this.ToCelsius());
            return c.ToRankine();
        }

        public double ToReaumur()
        {
            Celsius c = new Celsius(this.ToCelsius());
            return c.ToReaumur();
        }
    }
}
