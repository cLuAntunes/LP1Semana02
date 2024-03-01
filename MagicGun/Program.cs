using System;

namespace MagicGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            string numero = Console.ReadLine();

            int n = int.Parse(numero);

            
            int i = 0;
            while (true)
            {
                i++;

                if (i > n)
                {
                    break;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}: Magic Fire!");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}: Eletric Fire!");
                }
                else
                {
                    Console.WriteLine($"{i}: Normal Fire :/");
                }

            }


        }
    }
}
