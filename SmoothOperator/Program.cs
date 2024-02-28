using System;

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


            }
        }
    }
}
