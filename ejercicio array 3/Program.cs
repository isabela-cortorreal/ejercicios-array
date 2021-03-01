using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meses = {
                0,
                31,
                28,
                31,
                30,
                31,
                30,
                31,
                31,
                30,
                31,
                30,
                31
            };
            
            Console.Write("Ingrese el numero del mes que quiere consultar: ");
            int mes = int.Parse(Console.ReadLine());
            int result = meses[mes];
            Console.WriteLine("El mes numero {0} ", mes + " tiene: " + result + " dias");

            Console.ReadKey();
        }
    }
}
