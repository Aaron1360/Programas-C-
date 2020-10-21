using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Prácticas I (para adquirir la inmortalidad)
 * Alumno: Aaron Moreno Villeda
 * Carrera: Ingeniería en Mecatrónica
 * Grupo: 1MM5
 * El dia 21/10/2020
 * 15.-Programa para la generación de figuras con * 
 */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {/*Variables a utilizar
          * A -> Año [int]
          * n->Numero de filas [int]
          * i->contador [int]
          * j->contador [int]
          */
            try
            {
                int A, n = 0;

                Console.Write("GENERADOR DE FIGURAS\n\nSelecciona una figura ingresando el numero asociado:\n\n1) Piramide\n\n2) Medio diamante\n\n3) Diamante\n\n");
                A = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (A)
                {
                    case 1:
                        Console.Write("Ingresa el numero de filas [1-20]: ");
                        n = Convert.ToInt32(Console.ReadLine());

                        if (n > 0 && n <= 20)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j <= i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nel valor debe ser un entero positivo entre 1 y 20");
                        }
                        break;

                    case 2:

                        Console.Write("Ingresa el numero de filas [1-20]: ");
                        n = Convert.ToInt32(Console.ReadLine());

                        if (n > 0 && n <= 20)
                        {
                            for (int i = 0; i <= n; i++)
                            {
                                for (int j = 0; j <= i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                            for (int i = n; i >= 0; i--)
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nel valor debe ser un entero positivo entre 1 y 20");
                        }
                        break;

                    case 3:

                        Console.Write("Ingresa el numero de filas [1-20]: ");
                        n = Convert.ToInt32(Console.ReadLine());

                        if (n > 0 && n <= 20)
                        {
                            for (int i = 0; i < n + 1; i++)
                            {
                                for (int j = n; j > i; j--)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = 0; j <= 2 * i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                            for (int i = n; i >= 0; i--)
                            {
                                for (int j = n; j > i - 1; j--)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = 2 * i - 1; j > 0; j--)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                        }

                        else
                        {
                            Console.WriteLine("\nel valor debe ser un entero positivo entre 1 y 20");
                        }

                        break;

                    default:

                        Console.WriteLine("Error, opcion desconocida");
                        break;

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
