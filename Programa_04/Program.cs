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
 * 4.-Generar un algortimo que permita generar un triángulo con *, 
 * solicitando al usuario el número de filas a generar (en un intervalo de 1 a 10)
 */
namespace Programa_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variables a utilizar
          * n -> Número de filas [int]
          * i,j -> contadores [int]
          * r -> Respuesta del usuario [char]
          */
            int n,i,j;
            char r;

            while (true)
            {
                try
                {   
                    Console.WriteLine("Ingresa el número de filas: ");
                    n = Convert.ToInt32(Console.ReadLine());

                    if ((n >= 1) && (n<=10))
                    {
                        for (i = 1; i <= n; i++)
                        {
                            for (j = 1; j <= n - i; j++)
                            {
                                Console.Write(" ");
                            }

                            for(j=1;j<=2*i-1;j++)
                            {
                                Console.Write("*");
                            }
                            Console.Write("\n");
                        }
                    }
                    
                    else
                    {
                        Console.WriteLine("\nEl número debe ser entero y tener un valor entre 1 y 10");
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
