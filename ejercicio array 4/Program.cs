using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int cont, mayor;

            for(cont = 0; cont < 10; cont++)
            {
                Console.Write("Introduzca el numero {0}: ", cont + 1); 
                num[cont] = int.Parse(Console.ReadLine());
            }
            
            if (num[0] > num[1])
            {
                mayor = num[0];
            }
            else
            {
                mayor = num[1];
            }

            if (mayor < num[2])
            {
                mayor = num[2];
            }

            if (mayor < num[3])
            {
                mayor = num[3];
            }

            if (mayor < num[4])
            {
                mayor = num[4];
            }

            if (mayor < num[5])
            {
                mayor = num[5];
            }

            if (mayor < num[6])
            {
                mayor = num[6];
            }

            if (mayor < num[7])
            {
                mayor = num[7];
            }

            if (mayor < num[8])
            {
                mayor = num[8];
            }

            if (mayor < num[9])
            {
                mayor = num[9];
            }

            Console.WriteLine("El numero mayor es: " + mayor);
            Console.ReadKey();
        }
    }
}
