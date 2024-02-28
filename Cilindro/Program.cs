using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura do Cilindro:");

            string num1 = Console.ReadLine();

            float alt = float.Parse(num1);

            Console.WriteLine("Insira o raio do Cilindro:");

            string num2 = Console.ReadLine();

            float raio = float.Parse(num2);

        }
    }
}
