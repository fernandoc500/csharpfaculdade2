using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperaturas
{
    class Rankine : Temperatura
    {
        public Rankine (double temp)
        {
            this.temp = temp;
        }

        public double ToCelsius()
        {
            Kelvin k = new Kelvin(this.ToKelvin());
            return k.ToCelsius();
        }

        public double ToFahrenheit()
        {
            Kelvin k = new Kelvin(this.ToKelvin());
            return k.ToFahrenheit();
        }

        public double ToKelvin()
        {
            return this.temp / 1.8;
        }

        public double ToReaumur()
        {
            Kelvin k = new Kelvin(this.ToKelvin());
            return k.ToReaumur();
        }
    }
}
