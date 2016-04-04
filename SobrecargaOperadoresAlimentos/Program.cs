using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadoresAlimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            var lasania = new Lasania();
            var pan = new Pan();

            var Suma = lasania._temperatura + pan._temperatura;

            System.Console.WriteLine("Suma::lasania + pan = " + Suma);
            Console.ReadLine();

        }
    }
}
