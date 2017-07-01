using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Random rand = new Random();

            for (int y = 0; y < 20; y++)
            {
                lista.Add(rand.Next(300));
            }

            lista.Sort();

            foreach(int x in lista)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
