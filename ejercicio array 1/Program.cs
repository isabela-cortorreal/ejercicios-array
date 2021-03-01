using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1___array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[4];
            double suma = 0, media;
            int num;

            Console.Write("Ingrese 4 números para calcular su media aritmética y mostrar en pantalla la media y los datos tecleados :3" + "\n");

            for(num = 0; num < 4; num++)
            {
                Console.Write("\n" + "Ingrese el valor {0}: ", num + 1);
                numeros[num] = double.Parse(Console.ReadLine());
                suma += numeros[num];
            }

            media = suma / 4;
            Console.Write("\n" + "Los numeros que ingreso fueron: ");
            for(num = 0; num < 4; num++)
            {
                Console.Write("\n" + "({0}) ", numeros[num]);
            }

            Console.Write("\n" + "La media aritmetica es: {0}", media);
            Console.ReadKey();
        }
    }
}
