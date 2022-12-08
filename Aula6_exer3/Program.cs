using System;

namespace Aula6_exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 3) Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X,\n" +
                                  " um valor por linha, inclusive o X, se for o caso.");
            Console.WriteLine();
            Console.WriteLine("Informe um valor inteiro de 1 a 1000");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
