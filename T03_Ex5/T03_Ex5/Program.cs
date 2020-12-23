using System;

namespace T03_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programa de consola que declare cuatro variables enteras A, B, C
            y D y asígnale un valor a cada una. A continuación realiza las
            instrucciones necesarias para que:
            • B tome el valor de C
            • C tome el valor de A
            • A tome el valor de D
            • D tome el valor de B
            */

            int A = 1;
            int B = 2;
            int C = 3;
            int D = 4;

            Console.WriteLine("A={0}, B={1}, C={2}, D={3}", A, B, C, D);

            Console.WriteLine("B tome el valor de C, B={0}", B=C);
            Console.WriteLine("C tome el valor de A, C={0}", C=A);
            Console.WriteLine("A tome el valor de D, A={0}", A=D);
            Console.WriteLine("D tome el valor de B, D={0}", D=B); //El valor de D pasa a ser 3 y no 2 ya que hemos cambiado el valor de B en la primera orden.
        }
    }
}
