using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Prácticas I (para adquirir la inmortalidad)
 * Alumno: Aaron Moreno Villeda
 * Carrera: Ingeniería en Mecatrónica
 * Grupo: 1MM5
 * El dia 14/10/2020
 * 5.-Generar un algoritmo que indique si al ingresar un número entero positivo, este es par o impar
 */
namespace Programa_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variables a utilizar
            * n -> Número a evaluar [int]
            * r -> Respuesta del usuario [char]
            */
            int n;
            char r;

            while (true)
            {
                try
                {
                    Console.WriteLine("Ingresa un número entero positivo: ");
                    n = Convert.ToInt32(Console.ReadLine());

                    if ((n >= 0) && (n % 2 == 0))
                    {
                        Console.WriteLine("El número es par");
                    }

                    else if (n < 0)
                    {
                        Console.WriteLine("El número debe ser positivo");                 
                    }

                    else
                    {
                        Console.WriteLine("El número es impar");
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
