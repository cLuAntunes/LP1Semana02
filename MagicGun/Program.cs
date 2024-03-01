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

                if (i >= n)
                {
                    break;
                }

                Console.WriteLine(i);

            }

             Console.WriteLine(i);

        }
    }
}
