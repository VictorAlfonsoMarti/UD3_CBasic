using System;

namespace T03_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa de consola que realice lo siguiente: declarar dos variables X e Y de
            tipo int, dos variables N y M de tipo double y asigna a cada una un valor. A continuación
            muestra por pantalla:
            • El valor de cada variable.
            • La suma X + Y
            • La diferencia X – Y
            • El producto X * Y
            • El cociente X / Y
            • El resto X % Y
            • La suma N + M
            • La diferencia N – M
            • El producto N * M
            • El cociente N / M
            • El resto N % M
            • La suma X + N
            • El cociente Y / M
            • El resto Y % M
            • El doble de cada variable
            • La suma de todas las variables
            • El producto de todas las variables*/

            int X = 2;
            int Y = 6;
            double N = 0.5;
            double M = 10.6;

            Console.WriteLine("Valor de X={0}, Y={1}, N={2}, M={3}", X, Y, N, M);
            Console.WriteLine("La suma X + Y = {0}", X+Y);
            Console.WriteLine("La diferencia X – Y = {0}", X-Y);
            Console.WriteLine("El producto X * Y = {0}", X*Y);
            Console.WriteLine("El cociente X / Y = {0}", X/Y);
            Console.WriteLine("El resto X % Y = {0}", X%Y);
            Console.WriteLine("La suma N + M = {0}", N+M);
            Console.WriteLine("La diferencia N – M = {0}", N-M);
            Console.WriteLine("El producto N * M = {0}", N*M);
            Console.WriteLine("El cociente N / M = {0}", N/M);
            Console.WriteLine("El resto N % M = {0}", N%M);
            Console.WriteLine("La suma X + N = {0}", X+N);
            Console.WriteLine("El cociente Y / M = {0}", Y/M);
            Console.WriteLine("El resto Y % M = {0}", Y%M);
            Console.WriteLine("El doble de cada variable X={0}, Y={1}, N={2}, M={3}", X*2, Y*2, N*2, M*2);
            Console.WriteLine("La suma de todas las variables = {0}", X+Y+N+M);
            Console.WriteLine("El producto de todas las variables = {0}", X*Y*N*M);
        }
    }
}
