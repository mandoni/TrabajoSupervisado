using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1 
            int[] numeros = new int[13];// { 85, 96, 65, 70, 55, 45, 62, 95, 74, 100, 74, 83, 93 };

            for(int i = 0; i< 13; i++)
            {
                Console.WriteLine(String.Format("Ingrese la nota {0}", i + 1));
                try
                {
                    numeros[i] = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine(String.Format("La nota en la posición 5 es {0}\n" +
                            "La primera nota del arreglo es {1}\n" +
                            "La última nota es {2}\n" +
                            "La nota en la posición 7 es {3}\n" +
                            "La nota en la posición 10 es {4}\n" +
                            "La nota en la psición 3 es {5}", numeros[5], numeros[0], numeros[12], numeros[7], numeros[10], numeros[3]));
            Console.ReadKey();

            //Ejercicio 2
            int []array = new int[50];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
            Console.Clear();
            try
            {
                Console.WriteLine("Ingrese el número de posiciones que desea ver");
                string salida = "";
                int cantidad = int.Parse(Console.ReadLine());
                for(int i = 0; i < cantidad; i++)
                {
                    salida += array[i] + "\t";
                }
                Console.WriteLine(salida);
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
                Console.ReadKey();
                return;
            }

            //Ejercicio 3
            try
            {
                Console.WriteLine("Ingrese la cantidad de números que desea agregar al array.");
                string salida = "";
                int cantidad = int.Parse(Console.ReadLine());
                array = new int[cantidad];
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("Ingrese la cantidad para la posición " + (i +1));
                    array[i] = int.Parse(Console.ReadLine());
                    salida += cantidad + "\t";
                }
                Console.WriteLine(salida);
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
                Console.ReadKey();
                return;
            }

        }
    }
}
