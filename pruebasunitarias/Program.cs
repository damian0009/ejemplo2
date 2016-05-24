using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasunitarias
{
    class Program
    {
        static void Main(string[] args)
        {
            prueba(@"c:\informacion.txt");
            Console.ReadKey();
        }

        public static void prueba(string ruta)

        {
            funciones func = new funciones();
            string texto;
            System.IO.StreamReader file = new System.IO.StreamReader(ruta);

            while ((texto = file.ReadLine()) != null)
            {

                string[] vals = texto.Substring(texto.IndexOf(":") + 1).Split(':');
                string numero = texto.Substring(0, texto.IndexOf(":"));
                string operacion = vals[0];
                int[] valores = Array.ConvertAll(vals[1].Split(' '), s => int.Parse(s));
                string solucion = vals[2];

                List<string> ListaEscribir = new List<string>() { };

                if (operacion == "mediaAritmetica")
                {
                    if (func.mediaAritmetica(valores) == double.Parse(solucion))
                    {
                        Console.WriteLine("Exito--> {0}:{1}:{2}:{3}", numero, operacion, vals[1], solucion);
                        ListaEscribir.Add("Exito--> {0}:{1}:{2}:{3}" + ", " + numero + ", " + operacion + ", " + vals[1] + ", " + solucion);
                    }

                    else
                    {
                        Console.WriteLine("Fracaso--> {0}:{1}:{2}:{3} ::: Resultado maquina: {4}", numero, operacion, vals[1], solucion, func.mediaAritmetica(valores));
                        ListaEscribir.Add("Fracaso--> {0}:{1}:{2}:{3} ::: Resultado maquina: {4}" + ", " + numero + ", " + operacion + ", " + vals[1] + ", " + solucion + ", " + func.mediaAritmetica(valores));
                    }
                }

                if (operacion == "mediaGeometrica")

                {
                    if (func.mediaGeometrica(valores) == double.Parse(solucion))
                    {
                        Console.WriteLine("Exito--> {0}:{1}:{2}:{3}", numero, operacion, vals[1], solucion);
                        ListaEscribir.Add("Exito--> {0}:{1}:{2}:{3}" + ", " + numero + ", " + operacion + ", " + vals[1] + ", " + solucion);
                    }

              
                   else

                        Console.WriteLine("Fracaso--> {0}:{1}:{2}:{3} : Resultado maquina: {4}", numero, operacion, vals[1], solucion, func.mediaGeometrica(valores));
                        ListaEscribir.Add("Fracaso--> {0}:{1}:{2}:{3} : Resultado maquina: {4}" + ", " + numero + ", " + operacion + ", " + vals[1] + ", " + solucion + ", " + func.mediaGeometrica(valores));

                }

                if (operacion == "mediaArmonica")

                {
                    if (func.mediaArmonica(valores) == double.Parse(solucion))

                    {
                        Console.WriteLine("Exito--> {0}:{1}:{2}:{3}", numero, operacion, vals[1], solucion);
                        ListaEscribir.Add("Exito--> {0}:{1}:{2}:{3}" + ", " + numero + ", " + operacion + ", " + vals[1] + ", " + solucion);
                    }

                    else

                        Console.WriteLine("Fracaso--> {0}:{1}:{2}:{3} : Resultado maquina: {4}", numero, operacion, vals[1], solucion, func.mediaArmonica(valores));
                        ListaEscribir.Add("Fracaso--> {0}:{1}:{2}:{3} : Resultado maquina: {4}" + ", " + numero + ", " + operacion + ", " + vals[1] + ", " + solucion + ", " + func.mediaArmonica(valores));

                }

                using (StreamWriter escribir = new StreamWriter(@"c:\resultados.txt"))
                {
                    foreach (string x in ListaEscribir)
                    {
                        escribir.WriteLine(x);
                    }
                }

                Console.ReadKey();
            }

            file.Close();
        }
    }
}
