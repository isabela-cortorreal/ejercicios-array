using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8_array
{
    class Program
    {
        static float[] altura;
        static float promedio;

        static void Main(string[] args)
        {
            ingresar_altura();
            calc_promedio();
            mayor_menor();
        }

        static void ingresar_altura()
        {
            altura = new float[5];
            for (int a = 0; a < 5; a++)
            {
                Console.Write("Ingrese altura de la persona: ");
                altura[a] = float.Parse(Console.ReadLine());
            }
        }

        static void calc_promedio()
        {
            float suma = 0;

            for (int a = 0; a < 5; a++)
            {
                suma += altura[a];
            }

            promedio = suma / 5;
            Console.WriteLine("El promedio de altura es: " + promedio);
        }

        static void mayor_menor()
        {
            int mayor = 0, menor = 0;

            for (int a = 0; a < 5; a++)
            {
                if (altura[a] > promedio)
                {
                    mayor++;
                }
                else
                {
                    if (altura[a] < promedio)
                    {
                        menor++;
                    }
                }
            }

            Console.WriteLine("Cantidad de personas mayores al promedio: " + mayor);
            Console.WriteLine("Cantidad de personas menores al promedio: " + mayor);
            Console.ReadKey();
        }
    }
}
