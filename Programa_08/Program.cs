using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Prácticas I (para adquirir la inmortalidad)
 * Alumno: Aaron Moreno Villeda
 * Carrera: Ingeniería en Mecatrónica
 * Grupo: 1MM5
 * El dia 19/10/2020
 * 8.-Generar un algoritmo que permita obtener y desplegar los N primeros números primos, 
 * en donde N es un número entero positivo, el cual ingresa el usuario. Recordar que los números
 * primos son aquellos que solo son divisibles entre si mismos y entre 1. Si N=8, el programa debe 
 * mostrar 2,3,5,7,11,13,17,19
 */


namespace Programa_08
{
    class Program
    {
        static void Main(string[] args)
        {/*Variables a utilizar
            *num->cantidad de numeros primos [int]
            *i->contador [int]
            *n->
            *cont->Contador [int]
            */
			
			int num,i, n = 4, cont = 2;
			
			string cad = "";
			
			Console.Write("ingrese un numero: ");
			
			num = Convert.ToInt32(Console.ReadLine());
			
			if (num > 2)
			{
				cad = "2 3";
				
				while (cont < num)
				{
					for (i = 2; i <= n; i++)
					{
						if (i == n)
						{
							cad = cad + " " + Convert.ToString(n);
							cont = cont + 1;
						}

						else
						{
							if (n % i == 0)
							{
								i = n;
							}
						}
					}
					n = n + 1;
				}
				Console.WriteLine("\n"+cad);
			}

			else
			{
				if (num > 0)
				{
					if (num == 1)
					{
						Console.WriteLine("2");
					}
					else
					{
						Console.WriteLine("2 3");
					}
				}
				else
				{
					Console.WriteLine("ingresa numeros positivos");
				}
			}

			Console.ReadKey();
		}
    }
}
