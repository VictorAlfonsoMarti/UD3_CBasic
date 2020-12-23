using System;

namespace T03_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declara dos variables numéricas (con el valor que desees), muestra por consola la suma,
resta, multiplicación, división y módulo (resto de la división).*/

            int num1 = 4;
            int num2 = 5;

            Console.WriteLine("Número x = {0}, número y = {1}: Suma x+y={2}, Resta x-y={3}, Multiplicación x·y={4}, División x/y={5}, Módulo x%y={6}", num1, num2, num1+num2, num1-num2, num1*num2, num1/num2, num1%num2);
        }
    }
}
