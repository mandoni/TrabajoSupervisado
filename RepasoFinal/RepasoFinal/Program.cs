using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arregloMarcas = new string[20];
            int[] arregloCantLatas = new int[20];
            double[] arregloPrecio = new double[20];
            double[,] matrizVentas = new double[20, 24];
            for (int i = 0; i < 20; i++)
            {
                arregloMarcas[i] = "";
                arregloPrecio[i] = -1;
                arregloCantLatas[i] = -1;
                for (int j = 0; j < 24; j++)
                {
                    matrizVentas[i, j] = 0;
                }
            }
            int opcion = 0;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1. Configurar/Actualizar bandeja\n" +
                    "2. Expender\n" +
                        "3. Información Expendedora\n" +
                        "4. Listado de facturación por hora" +
                        "5. Salir");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese la marca a ingresar.");
                            string marca = Console.ReadLine();
                            Console.WriteLine("Ingrese la cantidad de latas.");
                            int cant = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la precio de  la lata.");
                            double price = double.Parse(Console.ReadLine());
                            int p = 0;
                            if ((p = Buscar(arregloMarcas, marca)) == -1)
                            {
                                if (p == -1)
                                {
                                    for (int i = 0; i < arregloMarcas.Length; i++)
                                    {
                                        if (arregloMarcas[i] == "")
                                        {
                                            p = i;
                                            break;
                                        }
                                    }
                                }
                                arregloMarcas[p] = marca;
                                arregloCantLatas[p] = cant;
                                arregloPrecio[p] = price;
                            }
                            else
                            {
                                arregloCantLatas[p] += cant;
                                arregloPrecio[p] = price;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese la merca de la bebida que desea.");
                            Console.WriteLine("Disponible: ");
                            for (int i = 0; i < arregloMarcas.Length; i++)
                            {
                                Console.Write(arregloMarcas[i] + "\t");
                            }
                            
                            string expender = Console.ReadLine();
                            int t = 0;
                            if ((t = Buscar(arregloMarcas, expender)) == -1)
                            {
                                Console.WriteLine("Opcion no válida.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                if (arregloCantLatas[t] != 0)
                                {
                                    Console.WriteLine("Ingrese la hora (0 - 23).");
                                    int hora = int.Parse(Console.ReadLine());
                                    arregloCantLatas[t]--;
                                    matrizVentas[t, hora] += arregloPrecio[t];

                                }
                                else
                                {
                                    Console.WriteLine("No queda en stock de esa bebida.");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            break;
                        case 3:
                            for (int i = 0; i < arregloMarcas.Length; i++)
                            {
                                if (arregloMarcas[i] != "")
                                {
                                    Console.WriteLine((i + 1) + "\t Marca: " + arregloMarcas[i] + "\n\tPrecio "
                                        + arregloPrecio[i] + "\n\tStock: " + arregloCantLatas[i]
                                        + "\n\tVentas del dia $" + getDayTotal(i, matrizVentas));
                                }
                            }
                            double total = 0;
                            for (int i = 0; i < 20; i++)
                            {
                                for (int j = 0; j < 24; j++)
                                {
                                    total += matrizVentas[i, j];
                                }
                            }
                            Console.WriteLine("Total: $" + total);
                            Console.ReadKey();
                            break;
                        case 4:
                            List<string> lista = new List<string>();
                            double dia = 0;
                            for (int i = 0; i < 20; i++) 
                            {
                                for (int j = 0; j < 24; j++) 
                                {
                                    dia += matrizVentas[i, j];
                                }
                                lista.Add(dia + " - " + arregloMarcas[i]);
                                dia = 0;
                            }
                            lista.Sort();
                            foreach (var x in lista)
                            {
                                Console.WriteLine(x);
                            }
                            Console.ReadKey();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Opcion fuera de los parametros.");
                            Console.ReadKey();
                            Console.Clear();
                            opcion = 6;
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Caracter no válido");
                    Console.ReadKey();
                    Console.Clear();
                    opcion = 6;
                }
            } while (opcion != 5);
        }
        public static int Buscar(string[] array, string buscar)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == buscar)
                    return i;
            }
            return -1;
        }

        public static double getDayTotal(int i, double[,] matriz)
        {
            double t = 0;
            for(int j = 0; j < 24; j++)
            {
                t += matriz[i, j];
            }
            return t;
        }
    }
}
