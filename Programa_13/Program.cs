using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
/*Prácticas I (para adquirir la inmortalidad)
 * Alumno: Aaron Moreno Villeda
 * Carrera: Ingeniería en Mecatrónica
 * Grupo: 1MM5
 * El dia 20/10/2020
 * 13.-Programa para generar un triángulo de Pascal en donde el usuario 
 * ingrese el número de filas que desea observar del triángulo
 */
namespace Programa_13
{
    class Program
    {
        static void Main(string[] args)
        {/*Variables a utilizar
          * n->numero ingresado por el usuario [int]
          * triangulo->matriz [int,int]
          * i->contador [int]
          * j->contador [int]
          * res->resultado
          */
            int n, i, j;
            
            try 
            {
                Console.Write("Ingresa el numero de filas: ");
                n = Convert.ToInt32(Console.ReadLine());

                int[,] triangulo = new int[n, n];

                for (i = 0; i < n; i++)
                {
                    triangulo[i, 0] = 1;
                }

                for (i = 0;i < n; i++)
                {
                    triangulo[i, i] = 1;
                }

                for(i = 2; i < n; i++)
                {
                    for(j = 1; j < i; j++)
                    {
                        triangulo[i, j] = triangulo[i - 1, j] + triangulo[i - 1, j - 1];
                    }
                }

                for(i = 0; i < n; i++)
                {
                    string res = "";
                    for (int k = 1; k <= n - i; k++)
                    {
                        Console.Write(" ");
                    }
                    for(j = 0; j <= i; j++)
                    {
                        res += triangulo[i, j];
                    }
                    Console.WriteLine(res);
                  
                }
            }

            catch(Exception e)
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
