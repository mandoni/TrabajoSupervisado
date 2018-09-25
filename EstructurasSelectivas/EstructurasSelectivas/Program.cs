using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasSelectivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ejercicio 1 \nIngrese un número.");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEl número " + numero + ":");

            if (numero % 2 == 0)
                Console.WriteLine("\t-Par.");
            else if (numero % 3 == 0)
                Console.WriteLine("\t-Es impar múltiplo de 3.");

            switch (numero)
            {
                case 1: case 2: case 3: case 4:
                    Console.WriteLine("\t-Pertenece al conjunto [1, 2, 3, 4].");
                    break;
            }

            if(numero>0 && numero < 13)
            {
                Console.Write("\t-Corresponde a un mes del año: ");
                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Enero");
                        break;
                    case 2:
                        Console.WriteLine("Febrero");
                        break;
                    case 3:
                        Console.WriteLine("Marzo");
                        break;
                    case 4:
                        Console.WriteLine("Abril");
                        break;
                    case 5:
                        Console.WriteLine("Mayo");
                        break;
                    case 6:
                        Console.WriteLine("Junio");
                        break;
                    case 7:
                        Console.WriteLine("Julio");
                        break;
                    case 8:
                        Console.WriteLine("Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Septiembre");
                        break;
                    case 10:
                        Console.WriteLine("Octubre");
                        break;
                    case 11:
                        Console.WriteLine("Noviembre");
                        break;
                    case 12:
                        Console.WriteLine("Diciembre");
                        break;
                }
            }

            if (numero % 10 == 0)
                Console.Write("\t-Es múltiplo de 10: " + Math.Pow(numero,2));
            else
                Console.Write("\t-No es múltiplo de 10: " + Math.Pow(numero, 3));

            Console.ReadKey();
            Console.Clear();

            Console.Write("Ejercicio 2\nIngrese un número\n");
            numero = int.Parse(Console.ReadLine());

            if (numero > 1000) {
                Console.WriteLine("Número mayor a 1000");
                Console.ReadKey();
                return;
            }

            if (numero < 0)
            {
                Console.WriteLine("Número menor que 1");
                Console.ReadKey();
                return;
            }

            string salida = numero + " = ";
            
            if (numero % 1000 == 0)
            {
                salida += "M";
                Console.WriteLine(salida);
                Console.ReadKey();
                return;
            }

            if(numero % 100 >= 0)
            {
                switch (numero / 100)
                {
                    case 1:
                        salida += "C";
                        break;
                    case 2:
                        salida += "CC";
                        break;
                    case 3:
                        salida += "CCC";
                        break;
                    case 4:
                        salida += "CD";
                        break;
                    case 5:
                        salida += "D";
                        break;
                    case 6:
                        salida += "DC";
                        break;
                    case 7:
                        salida += "DCC";
                        break;
                    case 8:
                        salida += "DCCC";
                        break;
                    case 9:
                        salida += "CM";
                        break;
                }
                numero = numero % 100;
            }

            if (numero % 10 >= 0)
            {
                switch (numero / 10)
                {
                    case 1:
                        salida += "X";
                        break;
                    case 2:
                        salida += "XX";
                        break;
                    case 3:
                        salida += "XXX";
                        break;
                    case 4:
                        salida += "XL";
                        break;
                    case 5:
                        salida += "L";
                        break;
                    case 6:
                        salida += "LX";
                        break;
                    case 7:
                        salida += "LXX";
                        break;
                    case 8:
                        salida += "LXXX";
                        break;
                    case 9:
                        salida += "XC";
                        break;
                    case 10:
                        salida += "X";
                        break;
                }
                numero = numero % 10;
            }

            switch (numero)
            {
                case 1:
                    salida += "I";
                    break;
                case 2:
                    salida += "II";
                    break;
                case 3:
                    salida += "III";
                    break;
                case 4:
                    salida += "IV";
                    break;
                case 5:
                    salida += "V";
                    break;
                case 6:
                    salida += "VI";
                    break;
                case 7:
                    salida += "VII";
                    break;
                case 8:
                    salida += "VIII";
                    break;
                case 9:
                    salida += "IX";
                    break;
            }

            Console.WriteLine(salida);
            Console.ReadKey();
        }
    }
}
