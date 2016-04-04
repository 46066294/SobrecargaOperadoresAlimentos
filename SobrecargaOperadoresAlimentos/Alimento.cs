using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadoresAlimentos
{
    class Alimento
    {
        public double _temperatura {get; protected set;}

        // Overloading '+' operator:
        public static Alimento operator +(Alimento a, Alimento b) 
        {
            return new Alimento() { _temperatura = a._temperatura + b._temperatura };
        }

    }
}
