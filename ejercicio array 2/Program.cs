using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int num1, num2, numero;

            Console.WriteLine("Ingrese 5 numeros y para mostrarlos invertidos" + "\n");
            for (num1 = 0; num1 < 5; num1++)
            {
                Console.Write("Ingrese un numero {0}: ", num1 + 1);
                num[num1] = int.Parse(Console.ReadLine());
            }

            for (num2 = 5; num2 > 0; num2--)
            {
                numero = num[num2 - 1];
                Console.WriteLine("El numero en la posicion {0} ", num2 + " es: " + numero);
            }

            Console.ReadKey();
        }
    }
}
