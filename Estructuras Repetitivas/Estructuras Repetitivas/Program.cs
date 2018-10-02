using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_Repetitivas
{
    class Program
    {
        static void Main(string[] args) // método Main
        {
            int numero1, numero2;
            try
            {
                Console.WriteLine("Ingrese dos números:");
                numero1 = int.Parse(Console.ReadLine());
                numero2 = int.Parse(Console.ReadLine());

                if (numero1 <= 0)
                {
                    Console.WriteLine("Número 1 no válido.");
                    return;     //retorna fuera del método
                }

                if (numero2 <= 0)
                {
                    Console.WriteLine("Número 2 no válido.");
                    return;     //retorna fuera del método
                }

                int numero3;
                numero3 = Math.Max(numero1, numero2);
                numero2 = Math.Min(numero1, numero2);
                numero1 = numero3;

                do
                {
                    numero3 = numero2;
                    numero2 = numero1 % numero2;
                    numero1 = numero3;
                } while (numero2 != 0);

                Console.WriteLine(String.Format("{0} es el Máximo Común Divisor entre los dos números.", numero3));
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Valores no válidos.");
                Console.ReadKey();
                return;
            }

            Console.Clear();
            Console.WriteLine("\nIngrese la cantidad de números que quiere comparar:");
            int numeros;
            try
            {
                numeros = int.Parse(Console.ReadLine());
                int[] listaNumeros = new int[numeros];
                int i = 0;
                Console.Clear();
                while (i < numeros)
                {
                    Console.WriteLine(String.Format("Ingrese el {0}° número.", i + 1));
                    listaNumeros[i] = int.Parse(Console.ReadLine());
                    i++;
                    Console.Clear();
                }

                i = numero1 = numero2 = 0;
                while (i < numeros)
                {
                    if (i == 0)
                    {
                        numero1 = listaNumeros[i];
                        numero2 = listaNumeros[i];
                    }
                    else
                    {
                        numero1 = Math.Max(numero1, listaNumeros[i]);
                        numero2 = Math.Min(numero2, listaNumeros[i]);
                    }
                    i++;
                }

                i = 0;
                Console.Write("[");
                while (i < numeros)
                {
                    Console.Write(listaNumeros[i] + ", ");
                    i++;
                }
                Console.WriteLine("$]");

                Console.WriteLine(String.Format("El número menor es {0} y el número mayor es {1}.", numero2, numero1));
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Número no válido.");
                Console.ReadKey();
                return;
            }
            Console.Clear();

            Console.WriteLine("Ingrese un número.");
            try
            {
                numero1 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Carácter no válido");
                Console.ReadKey();
                return;
            }

            if (numero1 < 50 || numero1 > 200)
            {
                Console.WriteLine("Número fuera del rango.");
                Console.ReadKey();
                return;
            }

            int j = 2;
            numero2 = 0;
            Console.Write(String.Format("Los factores primos de {0} son: ", numero1));
            while(numero1 != 1)
            {
                if(numero1 % j == 0)
                {
                    Console.Write(j + ", ");
                    numero1 = numero1 / j;
                }
                else
                {
                    j++;
                }
            }
            Console.Write("$.");
            Console.ReadKey();
        }
    }
}
