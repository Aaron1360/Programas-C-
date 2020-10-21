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
 * 10.-Generar un algoritmo que permita el ingreso de un número entero positivo, y 
 * representarlo como la suma de sus unidades, decenas, centenas..., esto es, si se 
 * ingresa el valor de 1942 este debe de ser igual a: 1942 = 1000 + 900 + 40 + 2
 */
namespace Programa_10
{
    class Program
    {
        static void Main(string[] args)
        {
            {/*Variables a utilizar
              *n->Numero entero positivo ingresado por el usuario [int]
              *u->Unidades [int]
              *d-Decenas [int]
              *c->Centenas [int]
              *um->Unidades de millar [int]
              *A->Casos [int]
              */
                int n = 0, u = 0, d = 0, c = 0, um = 0;

                Console.Write("Ingresa un numero entero y positivo: ");
                n = Convert.ToInt32(Console.ReadLine());

                if ((n<0) || (n > 9999))
                {
                    Console.WriteLine("El numero debe ser positivo y menor o igual a 9999");
                }

                else
                {
                    u = n % 10;
                    d = (n - u) % 100;
                    c = (n - d - u) % 1000;
                    um = (n - c - d - u) % 10000;

                    if (n < 10)
                        {  
                        Console.WriteLine("{0} = {1} ",n,n);
                        }

                    else if(n < 100)
                        { 
                        Console.WriteLine("{0} = {1} + {2} ",n,u,d);
                        }    

                    else if (n < 1000)
                        {
                        Console.WriteLine("{0} = {1} + {2} + {3}", n, u, d, c);
                        }

                    else 
                        {
                        Console.WriteLine("{0} = {1} + {2} + {3} +{4}", n, u, d, c, um);
                        }
                }
                Console.ReadKey();
            }
        }
    }
}
