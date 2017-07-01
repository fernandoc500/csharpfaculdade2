using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_2_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = new Random().Next(200);

            int entrada = 0;



            do
            {
                entrada = Int32.Parse(Console.ReadLine().ToString());

                if (entrada < index)
                {
                    Console.WriteLine("O numero é maior");

                } else if (entrada > index)
                {
                    Console.WriteLine("O número é menor");
                } else
                {
                    Console.WriteLine("Acertou");
                }
            } while (entrada != index);


            Console.WriteLine($"{index}");
            Console.ReadLine();
        }
    }
}
