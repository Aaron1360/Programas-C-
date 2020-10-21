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
 * 2.-Generar un algoritmo que indique si al ingresar un año como un número entero positivo, 
 * este sea o no bisiesto. Un año es bisiesto si es múltiplo de 4, exceptuando los múltiplos de 100, 
 * que sólo son bisiestos cuando son múltiplos además de 400, por ejemplo el año 1900 no fue bisiesto, 
 * pero el año 2000 si lo es
 */
namespace Programa_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variables a utilizar
          * A -> Año [int]
          * r -> Respuesta del usuario [char]
          */
            int A;
            char r;

            while (true)
            {
                try
                {

                    Console.WriteLine("Introduce el año a evaluar(Número entero positivo): ");
                    A = Convert.ToInt32(Console.ReadLine());

                    if (A >= 0)
                    {
                        if (A % 4 == 0 && (A % 100 != 0 || A % 400 == 0))
                        {
                            Console.WriteLine("\nEl año es bisiesto");
                        }

                        else
                        {
                            Console.WriteLine("\nEl año no es bisiesto");
                        }
                    }

                    else
                    {
                        Console.WriteLine("\nEl número debe ser entero positivo");
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
