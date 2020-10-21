using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
/*Prácticas I (para adquirir la inmortalidad)
 * Alumno: Aaron Moreno Villeda
 * Carrera: Ingeniería en Mecatrónica
 * Grupo: 1MM5
 * El dia 20/10/2020
 * 12.-Generar un algoritmo que permita obtener una cantidad N de números pseudoaleatorios 
 * (donde N es un número entero, mayor a 0) utilizando para ello el método/algoritmo de 
 * generación de números congruencial
 */
namespace Programa_12
{
    class Program
    {
        static void Main(string[] args)
        {/*Variables a utilizar
          * a->multiplicador [double]
          * b->sesgo [double]
          * m->modulo [double]
          * x->valor inicial/semilla [double]
          * n->numero de elementos [int]
          * i->contador [int]
          * u->numero aleatorio normalizado [double]
          * aux->variable auxiliar [double]
          */
            
            decimal a,b,m,x,aux,u;
            int n;

            Console.WriteLine("GENERADOR DE NUMEROS ALEATORIOS\n");

            Console.WriteLine("*Cualquier valor ingresado debe ser un entero*\n\n");

            try
            {
                Console.Write("Multiplicador: ");

                a = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nSesgo: ");
                b = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nModulo: ");
                m = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nValor inicial: ");
                x = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nNumero de elementos: ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nn\tx\tx(n+1)\tu");

                for (int i = 1; i <= n; i++)
                {
                    u = decimal.Round(x / m, 4);

                    aux = ((a * x) + b) % m;

                    Console.Write("{0}\t{1}\t{2}\t{3}\n\n", i, x, aux, u);

                    x = aux;

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
