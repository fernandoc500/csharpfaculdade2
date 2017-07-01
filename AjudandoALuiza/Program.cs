using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudandoALuiza
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[10]
            String entrada1 = Console.ReadLine();
            String entrada2 = Console.ReadLine();

            int convertido1;
            int convertido2;

            convertido1 = Convert.ToInt32(entrada1);
            convertido2 = Convert.ToInt32(entrada2);

            Console.WriteLine(convertido1 + convertido2);

            Console.ReadLine();

        }
    }
}
