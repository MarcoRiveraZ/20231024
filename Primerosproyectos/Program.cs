﻿using System.Numerics;

namespace Primerosproyectos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, \nWorld\t!");
            Console.WriteLine(777); //entero (BigInteger - int)
            Console.WriteLine(88.50); //doble (double)
            Console.WriteLine(-70.50f); //flotante (float)
            Console.WriteLine(4+8);
            Console.WriteLine((4 + 8)*7/5.0);
            Console.WriteLine(4>8);
            Console.WriteLine(4 >= 8 && (5 == 7 || 5<=10));
            Console.WriteLine(4 <= 8 && (5 == 7 || 5 < 10));
        }
    }
}