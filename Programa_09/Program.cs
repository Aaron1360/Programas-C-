using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Prácticas I (para adquirir la inmortalidad)
 * Alumno: Aaron Moreno Villeda
 * Carrera: Ingeniería en Mecatrónica
 * Grupo: 1MM5
 * El dia 19/10/2020
 * 9.-Generar un algoritmo que permita Imprimir los N números de *la Serie de Padovan , 
 * donde N es un número entero positivo que *el usuario debe ingresar para obtener los valores de la serie
 */

namespace Programa_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variables a utilizar
            *a, b, c son los primeros 3 valores de la sucesion [int]
            *n->numero ingresado por el usuario [int]
            *d->variable donde se guarda el nuevo elemento de la sucesion [int]
            *i->contador [int]
            */
            int a = 1, b = 1, c = 1, d = 0, n;

            try
            {
                Console.WriteLine("Ingresa un valor entero y positivo: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n <= 0)
                { Console.WriteLine("El valor debe ser entero y positivo"); }

                if (n == 1)
                {
                    Console.Write("{0}", a);
                }

                else if (n == 2)
                {
                    Console.Write("{0} {1}", a, b);
                }

                else if (n == 3)
                {
                    Console.Write("{0} {1} {2}", a, b, c);
                }

                else if (n >= 4)
                {
                    Console.Write("{0} {1} {2} ", a, b, c);

                    for (int i = 1; i <= n; i++)
                    {
                        d = b + a;
                        a = b;
                        b = c;
                        c = d;

                        Console.Write("{0} ", d);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            { 
                Console.ReadKey(); 
            }
            


        }
    }
}
