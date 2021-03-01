using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5_array
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] nombre = new string[100];
            int cont = 0;
            do
            {
                Console.Write("Ingrese el nombre numero {0}: ", cont);
                cont++;
                nombre[cont] = Convert.ToString(Console.ReadLine());
            } while (nombre[cont] != "");

            Console.WriteLine("\n");
            for (cont = 0; cont < 101; cont++)
            {
                Console.WriteLine("El nombre numero {0} ", cont + " es: " + nombre[cont]);
            }
            Console.ReadKey();
        }
    }
}
