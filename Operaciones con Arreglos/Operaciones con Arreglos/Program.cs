using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_con_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            int[] ejercicio1 = new int[10];
            int mayor = int.MinValue, posicion = 0;
            Console.WriteLine("Ingrese 10 números:");
            try
            {
                for(int i = 0; i<10; i++)
                {
                    ejercicio1[i] = int.Parse(Console.ReadLine());
                    if (ejercicio1[i] > mayor)
                    {
                        mayor = ejercicio1[i];
                        posicion = i + 1;
                    }
                }
                Console.WriteLine(String.Format("El numero mayor es: {0}, en posicion {1}.\nSe repite en: ", mayor, posicion));
                for (int i = 0; i < 10; i++)
                {
                    if (mayor == ejercicio1[i] && i != posicion)
                        Console.Write((i + 1) + " ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Caracter no válido");
                Console.ReadKey();
            }
            Console.ReadKey();
            //Ejercicio 2
            Console.Clear();
            Random random = new Random();
            int[] evaluacion1 = new int[40];
            int[] evaluacion2 = new int[40];
            int[] evaluacion3 = new int[40];
            double[] total = new double[40];
            for (int i = 0; i < 40; i++) 
            {
                evaluacion1[i] = random.Next(0, 100);
                evaluacion2[i] = random.Next(0, 100);
                evaluacion3[i] = random.Next(0, 100);
            }

            total = Total(evaluacion1, evaluacion2, evaluacion3);

            for (int i = 0; i < 40; i++) 
            {
                Console.WriteLine(String.Format("Examen 1 = {0}\tExamen 2 = {1}\tExamen 3 = {2}\t\tTotal = {3}\n", evaluacion1[i], evaluacion2[i], evaluacion3[i], total[i]));
            }
            Console.ReadKey();
            //Tercer ejercicio
            Console.Clear();
            string[] carros = new string[7] { "Alfa Romeo", "Fiat", "Ford", "Mitsubishi", "Seat", "Toyota", ""};
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(carros[i]);
            }

            Console.WriteLine("Ingrese una marca de vehiculo:");
            string marca = Console.ReadLine();
            Console.WriteLine("\n");
            for (int i = 0; i < 6; i++)
            {
                if (String.Compare(marca, carros[i]) < 0)
                {
                    string aux;
                    while(i < 7)
                    {
                        aux = carros[i];
                        carros[i] = marca;
                        marca = aux;
                        i++;
                    }
                    continue;
                }
            }
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(carros[i]);
            }
            Console.ReadKey();
        }

        private static double[] Total(int[] examen1, int[] examen2, int[] examen3)
        {
            double[] retornar = new double[40];
            for (int i = 0; i < 40; i++)
            {
                retornar[i] = 0.30 * examen1[i] + 0.30 * examen2[i] + 0.40 * examen3[i];
            }
            return retornar;
        }
    }
}
