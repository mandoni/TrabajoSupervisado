using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluación_diagnóstico
{
    class Program
    {
        public static Estacionamiento[,] estacionamiento = new Estacionamiento[3, 200];
        static void Main(string[] args)
        {
            //goto Tres;
            int numero1, numero2;
            Console.WriteLine("Ejercicio 1.1\nIngrese dos números para comprobar si son amigos o no");
            try
            {
                numero1 = int.Parse(Console.ReadLine());
                numero2 = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Carácter ingresado no válido.");
                return;
            }

            if (Amigos(numero1, numero2))
                Console.WriteLine(String.Format("Los números {0} y {1} son amigos", numero1, numero2));
            else
                Console.WriteLine(String.Format("Los números {0} y {1} no son amigos", numero1, numero2));

            Console.ReadKey();
            Console.Clear();

            //==========================================================================================

            Console.WriteLine("Ejercicio 1.2\nIngrese dos números");
            try
            {
                numero1 = int.Parse(Console.ReadLine());
                numero2 = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Carácter ingresado no válido.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(string.Format("El MCD de {0} y {1} es: {2}", numero1, numero2, Euclides(numero1, numero2)));
            Console.ReadKey();
            Console.Clear();

            //===========================================================================================
            Tres:
            int opcion = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 200; j++)
                {
                    estacionamiento[i, j] = new Estacionamiento();
                }
            }

            do
            {
                Console.WriteLine("Menu\n" +
                    "1. Ingresar un nuevo carro\n" +
                    "2. Eliminar un carro \n" +
                    "3. Ver estacionamiento\n" +
                    "4. Salir\n");
                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Carácter no válido.");
                    Console.ReadKey();
                    return;
                }

                switch (opcion)
                {
                    case 1:
                        ADD();
                        break;
                    case 2:
                        Delete();
                        break;
                    case 3:
                        View();
                        break;
                    case 4:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            } while (opcion != 4);
           
        }

        /// <summary>
        /// Determina dos números son amigos. 
        /// Dos números son amigos si la suma de sus divisores es igual al otro numero. 
        /// </summary>
        /// <param name="a">Número ingresado por el usuario.</param>
        /// <param name="b">Númeroo ingresado por el usuario.</param>
        /// <returns></returns>
        private static bool Amigos(int a, int b)
        {
            if (Divisores(a) == b && Divisores(b) == a)
                return true;
            return false;
        }

        /// <summary>
        /// Hace la sumatoria de los divisores del número C.
        /// </summary>
        /// <param name="c">Númro del cuál se necesitan los divisores.</param>
        /// <returns></returns>
        private static int Divisores(int c)
        {
            int sumatoria = 0;
            for(int i = 1; i<c; i++)
            {
                if (c % i == 0)
                    sumatoria += i;
            }
            return sumatoria;
        }

        /// <summary>
        /// Utiliza el algorítmo de Euclides para encontrar el MCD
        /// </summary>
        /// <param name="a">Numero ingresado por el usuario</param>
        /// <param name="b">Numero ingresado por el usuario</param>
        /// <returns></returns>
        private static int Euclides(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Número no válido");
                return -1;
            }
            int aux = Math.Max(a, b), aux2, mcd = 0;
            b = Math.Min(a, b);
            a = aux;

            do {
                aux = a / b;
                aux2 = a % b;
                a = b;
                b = aux2;
                if (aux2 > 0)
                    mcd = aux2;
            } while (aux2 > 0);
            return mcd;
        }

        /// <summary>
        /// Retorna el primer parqueo disponible 
        /// </summary>
        /// <returns>Posicion de parqueo disponible</returns>
        private static int[] Disponible()
        {
            int[] r = { -1, -1 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 200; j++)
                {
                    if (estacionamiento[i, j].estado == false)
                    {
                        r[0] = i;
                        r[1] = j;
                        return r;
                    }
                }
            }
            return r;
        }

        private static void ADD()
        {
            Console.Clear();

            string[] entradas = new string[3];
            Console.WriteLine("Ingrese la marca del carro");
            entradas[0] = Console.ReadLine();
            Console.WriteLine("Ingrese la color del carro");
            entradas[1] = Console.ReadLine();
            Console.WriteLine("Ingrese la placa del carro");
            entradas[2] = Console.ReadLine();

            int[] libre = Disponible();

            estacionamiento[libre[0], libre[1]].NuevoCarro(entradas[0], entradas[1], entradas[2]);

            Console.Clear();
            estacionamiento[libre[0], libre[1]].getCarro(libre[0], libre[1]);

            Console.ReadKey();
            Console.Clear();
        }

        private static void Delete()
        {
            Console.WriteLine("Ingrese la posicion en que el carro salió");
            try
            {
                Console.Clear();

                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                if(estacionamiento[x, y].estado == false)
                {
                    Console.WriteLine("No hay nadie en este parqueo");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }

                estacionamiento[x, y].getCarro(x, y);
                Console.WriteLine("Saliendo...");
                estacionamiento[x, y].SalidaCarro();

                Console.ReadKey();
                Console.Clear();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR!");
                Console.ReadKey();
                Console.Clear();
                return;
            }
        }

        private static void View()
        {
            Console.Clear();
            Console.WriteLine("X: Ocupado\tO: Disponible");
            string line = "";
            for (int i = 0; i < 200; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (estacionamiento[j, i].estado)
                        line += "X\t";
                    else
                        line += "O\t";
                }
                Console.WriteLine(line);
                line = "";
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
