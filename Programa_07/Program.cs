using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Prácticas I (para adquirir la inmortalidad)
 * Alumno: Aaron Moreno Villeda
 * Carrera: Ingeniería en Mecatrónica
 * Grupo: 1MM5
 * El dia 15/10/2020
 * 7.-Generar un algoritmo que permita imprimir los números de la serie de Fibonacci, 
 * perimtiendo que se ingrese el número de elementos a desplegar N, como valor entero y positivo.
 * Recordar que la serie de Fibonacci es: 0,1,1,2,3,5,8,13,21,34,...
 */
namespace Programa_07
{
    class Program
    {
        static void Main(string[] args)
        {/*Variables a utilizar
            *a->Primer número de la sucesión [int]
            *b->Segundo número de la sucesión [int]
            *c->Variable auxiliar [int]
            *n->Cantidad de números de la sucesión [int]
            *cont->Contador de iteraciones [int]
            */
            int a = 0, b = 1, c = 0, n, cont;
            
                try
                {
                    Console.WriteLine("Ingresa un número entero positivo: ");
                    n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nSucesión de Fibonacci\n");

                    for (cont = 0; cont <= n; cont++)
                    {
                        if (c == 0)
                        {
                            Console.Write("{0} ", a);
                        }

                        else
                        {
                            Console.Write("{0} ", c);
                        }

                        c = a + b;
                        b = a;
                        a = c;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message, "\n");
                }

                finally
                {
                    Console.WriteLine("\n\nPara finalizar presione una tecla ");
                    
                    Console.ReadKey();
                }

            
        }
    }
}
