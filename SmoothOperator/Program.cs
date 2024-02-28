﻿using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro não-negativo: ");
            string inteiro = Console.ReadLine();

            int numin = int.Parse(inteiro);

             if (numin >= 0)
            {
                byte n = (byte)numin;

                byte decremento = (byte)(--n);
                Console.WriteLine(decremento);

                byte incremento = (byte)(++n);
                Console.WriteLine(incremento);

                byte div2 = (byte)(n / 2);
                Console.WriteLine(div2);

                byte sleft3 = (byte)(n << 3);
                Console.WriteLine(sleft3);

                byte xorc5 = (byte)(n ^ 5);
                Console.WriteLine(xorc5);

            }
        }
    }
}
