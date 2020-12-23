using System;

namespace T03_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa de consola que realice lo siguiente: declarar una variable N de tipo
              int, una variable A de tipo double y una variable C de tipo char y asigna a cada una un valor.
              A continuación muestra por pantalla:
              • El valor de cada variable.
              • La suma de N + A
              • La diferencia de A - N
              • El valor numérico correspondiente al carácter que contiene la variable C. */

            int N = 2;
            double A = 4;
            char C = '7';

            Console.WriteLine("Valores: N={0}, A={1}, C={2}", N, A, C);
            Console.WriteLine("Suma de N+A={0}", N+A);
            Console.WriteLine("Resta de A-N{0}", A-N);
            Console.WriteLine("Valor numérico del caràcter C={0}", (int)C);
        }
    }
}
