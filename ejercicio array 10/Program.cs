using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_10_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos_persona dat_per = new Datos_persona();
            dat_per.ingresar_datos();
            dat_per.mostrar_datos();
            dat_per.mayor_edad();
        }
    }
    class Datos_persona
    {
        string nombre;
        int edad;

        public void ingresar_datos()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());
        }

        public void mostrar_datos()
        {
            Console.WriteLine("\n" + "Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }

        public void mayor_edad()
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("No es mayor de edad");
            }
            Console.ReadKey();
        }

    }
}
