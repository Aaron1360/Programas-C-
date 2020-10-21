using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
/*Prácticas I (para adquirir la inmortalidad)
 * Alumno: Aaron Moreno Villeda
 * Carrera: Ingeniería en Mecatrónica
 * Grupo: 1MM5
 * El dia 14/10/2020
 * 6.-Generar un algoritmo que obtenga el Máximo Común Divisor (MCD) y 
 * el mínimo común múltiplo de un par de números enteros positivos. 
 * (Existe un algoritmo ya establecido para este caso, se le conoce como 
 * algoritmo de Euclídes) 
 */
namespace Programa_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variables a utilizar
            *n1->Primer número[int]
            *r1->valor asociado al primer número [int]
            *r2->valor asociado al segundo número [int]
            *n2->Segundo número[int]
            *res -> residuo de la division [int]
            *mcd -> Máximo Común Divisior [int]
            *mcm -> Mínimo Común Multiplo [int]
            *r ->Respuesta [char]
            */
            int n1, n2, r1, r2, res=1, mcd=0, mcm=0;
            char r;

            while (true)
            {
                try
                {
                    Console.WriteLine("Escribe el primer número: ");
                    n1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Escribe el segundo número: ");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    r1 = n1;
                    r2 = n2;
                    if ((n1 > 0) && (n2 > 0))
                    {
                        do
                        {
                            res = r1 % r2;

                            if (res != 0)
                            {
                                r1 = r2;
                                r2 = res;
                            }

                            else
                            {
                                mcd = r2;
                            }
                        }

                        while (res != 0);

                        mcm = (n1*n2) / mcd;

                        Console.WriteLine("El MCD es: {0}", mcd);
                        Console.WriteLine("\nEl MCM es: {0}", mcm);
                    }

                    else if ((n1 < 0) || (n2 < 0))
                    {
                        Console.WriteLine("Los números deben ser positivos");
                    }

                    else
                    {
                        Console.WriteLine("Los números son iguales");
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
