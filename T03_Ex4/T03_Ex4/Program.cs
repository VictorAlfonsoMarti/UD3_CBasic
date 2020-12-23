using System;

namespace T03_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa de consola que declare una variable entera N
            y asígnale un valor. A continuación escribe las instrucciones que
            realicen los siguientes:
            • Incrementar N en 77.
            • Decrementarla en 3.
            • Duplicar su valor.
            Si por ejemplo N = 1 la salida del programa será:
            • Valor inicial de N = 1
            • N + 77 = 78
            • N - 3 = 75
            • N * 2 = 150
            */

            int N = 1;

            Console.WriteLine("Valor inicial de N = {0}", N);
            Console.WriteLine("Incrementar N en 77 = {0}", N=N+77); //Asignamos nuevo valor a N cogiendo su valor anterior.
            Console.WriteLine("Decrementarla en 3 = {0}", N=N-3);
            Console.WriteLine("Duplicar su valor = {0}", N=N*2);
        }
    }
}
