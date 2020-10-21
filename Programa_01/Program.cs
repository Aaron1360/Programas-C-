using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Prácticas I (para adquirir la inmortalidad)
 * Alumno: Aaron Moreno Villeda
 * Carrera: Ingeniería en Mecatrónica
 * Grupo: 1MM5
 * El dia 13/10/2020
 * 1.-Generar un algoritmo que permita calcular el factorial de un número N ingresado por el usuario,
 * debe tomarse en cuenta que el usuario solo puede ingresar números enteros y positivos
 */

namespace Programa_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variables a utilizar
            *N -> Valor a calcular el factorial [int]
            *i -> Contador [int]
            *res -> Resultado [long]
            *r -> Respuesta del usuario [char]
            */
            int N, i;
            long res;
            char r;

            while (true)
            {
                try
                {

                    Console.WriteLine("Introduce un número entero positivo: ");
                    N = Convert.ToInt32(Console.ReadLine());

                    if (N >= 0)
                    {
                        for (i = 1, res = 1; i <= N; res *= i, i++) ;

                        Console.WriteLine("\nEl factorial de {0} es {1}", N, res);
                    }

                    else
                    {
                        Console.WriteLine("\nEl número debe ser entero y positivo");
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message, "\n");
                }

                finally
                {
                    Console.WriteLine("\n¿Desea repetir la operación?\nSi[tecla 'y'], No[Cualquier tecla]");
                    r = Convert.ToChar(Console.ReadLine());
                    Console.Write("\n");
                }

                if (r == 'y')
                {
                    Console.Clear();
                    continue;
                }

                else { break; }
            }
        }
    }
}
