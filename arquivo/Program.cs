using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linhas = File.ReadAllLines("C:/Users/Fernando/Desktop/teste.txt");
            int ind = 0;
            foreach (string linha in linhas)
            {
                if (ind == 0)
                {
                    Console.WriteLine(linha);
                    ind++;
                } else
                {
                    Console.WriteLine($"\t{ind++} - {linha}");

                    if (ind >= 10)
                    {
                        ind = 0;
                        Console.WriteLine();
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
