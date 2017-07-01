using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2905
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroContext ctx = new CarroContext();
            Carro aC = new Carro() { Placa = "HHH-5555", Portas = 5 };
            Carro bC = new Carro() { Placa = "HHH-6666", Portas = 6 };
            Carro cC = new Carro() { Placa = "HHH-7777", Portas = 7 };


            ctx.Carros.Add(aC);
            ctx.Carros.Add(bC);
            ctx.Carros.Add(cC);
            ctx.SaveChanges();

            var res = from c in ctx.Carros select c;

            foreach (Carro c in res)
            {
                Console.WriteLine(c.ToString());
            }

            
            
        }
    }
}
