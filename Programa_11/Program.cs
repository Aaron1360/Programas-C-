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
 * 11.-Programa que calcule el doble factorial (n!!) 
 * de un número entero positivo (Información del doble factorial)
 */
namespace Programa_11
{
    class Program
    {
        static void Main(string[] args)
        {/*Variables a utilizar
          * n ->Número ingresado por el usuario [int]
          * a->Valor inicial [int]
          * b->Valor inicial [int]
          * r -> Resultado[int]
          */
            int n=0, a= 0, b=-1, res=1;

            Console.WriteLine("FUNCION DOBLE FACTORIAL\n");

            try
            { 
                Console.WriteLine("Ingresa un numero entero positivo: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n >= 0)
                {
                    while (n > 0)
                    {
                        if (n % 2 == 0)
                        {
                            a += 2;
                            res *= a;
                            n -= 2;
                        }

                        else
                        {
                            b += 2;
                            res *= b;
                            n -= 2;
                        }
                    }

                    Console.WriteLine("El resultado es: {0}", res);
                }

                else
                { Console.WriteLine("El numero debe ser entero positivo"); }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message, "\n");
            }

            finally
            { 
                Console.ReadKey(); 
            }
           
        }
    }
}
