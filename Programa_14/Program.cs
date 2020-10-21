using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
/*Prácticas I (para adquirir la inmortalidad)
 * Alumno: Aaron Moreno Villeda
 * Carrera: Ingeniería en Mecatrónica
 * Grupo: 1MM5
 * El dia 20/10/2020
 * 14.-Generar un algoritmo que permita calcular 
 * el dígito de control del código de barras EAN-8
 */
namespace Programa_14
{
    class Program
    {
        static void Main(string[] args)
        {/*Variables
          * a->suma de numeros par [int]
          * b->suma de numeros impar [int]
          * c->digito de control [int]
          * x->indice de entradas [int]
          * i->contador [int]
          * r->respuesta [char]
          * ean->codigo de barras [int]
          */ 
            int  a = 0, b = 0, c = 0, x = 1 ;
            char r;
            int[] ean = new int[8];
            try
            {

                for (int k = 0; k < ean.Length; k++)
                {
                    Console.Write("Elemento {0}: ", x);
                    ean[k] = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if ((ean[k] >= 0) && (ean[k] <= 9))
                    {
                        x += 1;
                    }

                    else
                    {
                        Console.WriteLine("Los valores ingresados deben ser enteros positivos entre 0 y 9");
                        Console.WriteLine("\nPresiona una tecla para continuar: ");

                        Console.ReadKey();

                        Console.Clear();
                        k -= 1;
                        continue;
                    }

                }

                for (int i = 0; i < ean.Length; i++)
                {
                    if (ean[i] % 2 == 0)
                    {
                        a += ean[i];
                    }

                    else
                    {
                        b += ean[i];
                    }
                }

                c = 10 - ((3 * a + b) % 10);

                Console.WriteLine("Codigo EAN-13 version de 8 digitos:\n");

                foreach (int tmp in ean)
                {
                    Console.Write("{0} ", tmp);
                }
                Console.Write(c);

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
