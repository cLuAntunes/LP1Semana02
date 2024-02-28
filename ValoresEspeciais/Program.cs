using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"byte: mínimo = {byte.MinValue}");
            Console.WriteLine($"byte: máximo = {byte.MaxValue}");

            Console.WriteLine($"sbyte: mínimo = {sbyte.MinValue}");
            Console.WriteLine($"sbyte: máximo = {sbyte.MaxValue}");

            Console.WriteLine($"int: mínimo = {int.MinValue}");
            Console.WriteLine($"int: máximo = {int.MaxValue}");

            Console.WriteLine($"uint: mínimo = {uint.MinValue}");
            Console.WriteLine($"uint: máximo = {uint.MaxValue}");

            Console.WriteLine($"long: mínimo = {long.MinValue}");
            Console.WriteLine($"long: máximo = {long.MaxValue}");

            Console.WriteLine($"ulong: mínimo = {ulong.MinValue}");
            Console.WriteLine($"long: máximo = {ulong.MaxValue}");
        }
    }
}
