using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            char[] separar_nom = nombre.ToCharArray();
            foreach (char n in separar_nom)
            {
                Console.Write(n + " ");
            }
            Console.ReadKey();
        }
    }
}
