using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_array
{
    class Program
    {
        struct ficha
        {
            public string nombre_ficha;
            public long ancho_pi;
            public long altura_pi;
            public long tamano;
        };

        static void Main(string[] args)
        {

            ficha[] fichas = new ficha[700];
            int num_ficha = 0;  
            int c;               
            int menu;          
            string buscar_nom;  
            long buscar_imag;  

            do
            {
                
                Console.WriteLine("\n" + "----Menu----");
                Console.WriteLine("1.- Nueva imagen.");
                Console.WriteLine("2.- Mostrar informacion de las imagenes.");
                Console.WriteLine("3.- Buscar imagen por tamaño.");
                Console.WriteLine("4.- Buscar imagen por nombre.");
                Console.WriteLine("5.- Salir del programa.");

                Console.Write("\n" + "Ingrese una opcion del menu: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {

                    case 1:
                        if (num_ficha < 1000)
                        {
                            Console.Write("\n" + "Ingrese el nombre de la imagen: ");
                            fichas[num_ficha].nombre_ficha = Console.ReadLine();
                            Console.Write("Ingrese la anchura de pixeles: ");
                            fichas[num_ficha].ancho_pi = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese la altura de pixeles: ");
                            fichas[num_ficha].altura_pi = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el tamaño en KB: ");
                            fichas[num_ficha].tamano = int.Parse(Console.ReadLine());
                            num_ficha++;
                        } else {
                            Console.WriteLine("\n" + "Ha alcanzado el máximo de fichas (700)");
                        }
                           
                        break;

                    case 2: 
                        for (c = 0; c < num_ficha; c++)
                            Console.WriteLine("\n" + "Nombre: {0}; Anchura: {1} px; Altura: {2} px; Tamaño: {3} KB",
                            fichas[c].nombre_ficha, fichas[c].ancho_pi, fichas[c].altura_pi, fichas[c].tamano);
                        break;

                    case 3:
                        Console.Write("\n" + "Ingrese el tamaño de las imagenes que desea ver:");
                        buscar_imag = int.Parse(Console.ReadLine());

                        for (c = 0; c < num_ficha; c++)
                            if (fichas[c].tamano >= buscar_imag)
                                Console.WriteLine("\n" + "Nombre: {0}; Anchura: {1} px; Altura: {2} px; Tamaño: {3} KB",
                                fichas[c].nombre_ficha, fichas[c].ancho_pi, fichas[c].altura_pi, fichas[c].tamano);
                        break;

                    case 4: 
                        Console.Write("\n" + "Ingrese el nombre de las imagenes que desea ver:");
                        buscar_nom = Console.ReadLine();

                        for (c = 0; c < num_ficha; c++)
                            if (fichas[c].nombre_ficha == buscar_nom)
                                Console.WriteLine("\n" + "Nombre: {0}; Anchura: {1} px; Altura: {2} px; Tamaño: {3} KB",
                                fichas[c].nombre_ficha, fichas[c].ancho_pi, fichas[c].altura_pi, fichas[c].tamano);
                        break;

                    case 5: 
                        Console.WriteLine("\n" + "Fin del programa");
                        break;

                    default: 
                        Console.WriteLine("\n" + "Esta opcion no esta en el menu.");
                        break;

                } Console.ReadKey();

            } while (menu != 5); 
        }
    }
}
