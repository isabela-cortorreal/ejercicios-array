using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_9_array
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicio_9 ejer9 = new ejercicio_9();
            ejer9.ingresar_numero();
        }
    }

    class ejercicio_9
    {
        public void tabla_multiplicar(int v)
        {
            int cont = 0, result;

            for (cont = 1; cont <= 12; cont++)
            {
                result = cont * v;
                Console.WriteLine(cont + " X " + v + " = " + result);
            }
        }

        public void ingresar_numero()
        {
            int v_entero;
            do
            {
                Console.Write("\n" + "Ingrese un valor: ");
                v_entero = int.Parse(Console.ReadLine());
                if (v_entero != -1)
                {
                    tabla_multiplicar(v_entero);
                }
            } while (v_entero != -1);
        }
    }
}
