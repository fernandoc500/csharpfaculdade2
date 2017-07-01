using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperaturas
{
    class Celsius : Temperatura
    {
        public Celsius(double temp)
        {
            this.temp = temp;
        }

        public double ToFahrenheit ()
        {
            return (9 * this.temp / 5 + 32);
        }

        public double ToKelvin()
        {
            return this.temp + 273.15;
        }

        public double ToReaumur()
        {
            return (this.temp * 4) / 5;
        }

        public double ToRankine()
        {
            return this.ToKelvin() * 1.8;
        }
    }
}
