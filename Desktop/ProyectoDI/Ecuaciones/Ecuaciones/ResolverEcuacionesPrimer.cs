using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuaciones
{
    class ResolverEcuacionesPrimer
    {
        public static void resolve(int a, int b, int c, out double x)
        {
            if (a != 0)
            {
                x = (c - b) / (double)a;
            }
            else
            {
                x = Double.NaN;
            }            
        }
    }
}
