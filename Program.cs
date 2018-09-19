using System;

namespace Triangulo
{
    class Program
    {

        static int num = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el tamaño de la base: ");
            if (Int32.TryParse(Console.ReadLine().ToString(), out num)) {
                creaTriangulo(num);
            } else {
                Console.WriteLine("Debes ingresar un numero entero");
            }
        }

        static void creaTriangulo(int b) {
            String cadena = "";
            for (int i=1; i<=b; i++) {
                Console.Write(cadena.PadLeft(b-i, ' '));
                for (int j=0; j<i; j++) {
                    Console.Write("1 ");                    
                }
                Console.WriteLine("");
            }
        }
    }
}
