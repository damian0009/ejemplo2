using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasunitarias
{
    class funciones
    {
        // calcula y regresa la media aritmetica
        public double mediaAritmetica(params int[] vals)
        {
            double result = 0;

            for (int i = 0; i < vals.Length; i++)
            {
                result += vals[i];
            }
            return Math.Round(result / vals.Length, 2);
        }

        // calcula y regresa la raiz enesima = x^(1/n)
        private static double raizEnesima(double x, int n)
        {
            return Math.Round(Math.Pow(x, (double)1 / n), 2);
        }

        // usa raizEnesima para calcular y regresar la media geometrica
        public double mediaGeometrica(params int[] vals)
        {
            double num = 1;
            for (int i = 0; i < vals.Length; i++)
            {
                num *= vals[i];
            }
            return raizEnesima(num, vals.Length);
        }

        // Este metodo no esta implementado
        public double mediaArmonica(params int[] vals)
        {
            double sum = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                sum += (double)1 / vals[i];
            }
            return Math.Round(vals.Length / sum, 2);
        }
    }
}