using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperaturas
{
    class Reaumur : Temperatura
    {
        public Reaumur(double temp)
        {
            this.temp = temp;
        }

        public double ToCelsius()
        {
            return (this.temp * 5) / 4;
        }

        public double ToFahrenheit()
        {
            Celsius c = new Celsius(this.ToCelsius());
            return c.ToFahrenheit();
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
    }
}
