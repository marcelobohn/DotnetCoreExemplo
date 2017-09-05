using System;
using lib;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calc = new Calculadora();
            Console.WriteLine(calc.Soma(2,3));
        }
    }
}
