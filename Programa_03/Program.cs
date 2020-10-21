using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
/*Prácticas I (para adquirir la inmortalidad)
 * Alumno: Aaron Moreno Villeda
 * Carrera: Ingeniería en Mecatrónica
 * Grupo: 1MM5
 * El dia 14/10/20203.-Generar un algoritmo que si se ingresan 3 números positivos, se establezca que si son longitudes de líneas rectas, 
 * estás puedan formar un triángulo. Solamente se forma un triángulo, cuando la suma de las 2 longitudes de las rectas 
 * es mayor que la otra
 */
namespace Programa_03
{
    class Program
    {
        static void Main(string[] args)
        {/*Variables a utilizar
          *V-> longitudes del triangulo [int]
          * r -> Respuesta del usuario [char]
          */
            int n;
            char r;

            while (true)
            {
                try
                {   int[] V = new int[3];

                    for (n = 0; n < V.Length; n++)
                    {
                        Console.Write("Longitud {0}: ", n+1);
                        V[n] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.Write("\n");

                    foreach (int tmp in V)
                        Console.Write(" [{0}] ", tmp);

                    if( (V[0] + V[1]) > V[2] && (V[1] + V[2]) > V[0] && (V[0] + V[2]) > V[1])
                    {
                        Console.WriteLine("\nLas longitudes ingresadas si pueden formar un triángulo");
                    }
                   
                    else
                    {
                        Console.WriteLine("\nLas longitudes ingresadas no pueden formar un triángulo");
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

                else { break; }            }
        }
    }
}
