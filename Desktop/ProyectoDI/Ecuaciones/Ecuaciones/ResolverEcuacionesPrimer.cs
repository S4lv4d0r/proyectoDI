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
    class ResolverEcuacionesSegundo
    {
        public static void resolve(int a, int b, int c, int d, out double x1, out double x2)
        {
            c = c - d;
            double rad = Math.Pow(b,2)-4*a*c;
            if ((a == 0 && b == 0)||rad<0)
            {
                x1 = double.NaN;
                x2 = double.NaN;
            }
            else
            {
                x1 = (-b + Math.Sqrt(rad)) / (double)(2 * a);
                x2 = (-b - Math.Sqrt(rad)) / (double)(2 * a);
            }
        }
    }
}
