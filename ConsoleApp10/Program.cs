using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Случайный масив:");
            int[] ara = new int[50];
            Random rand = new Random();
            for (int i = 0; i < ara.Length; i++)
                ara[i] = rand.Next(-10, 10);
            for (int a = 0; a < ara.Length; a++)
                Console.WriteLine(ara[a]);
            Console.ReadKey();
            Console.WriteLine("Элементы в массиве абсолютная величина которых больше 7:");
            int count = 0;
            for (int y = 0; y < ara.Length; y++)
                if (Math.Abs(ara[y]) > 7)
                {
                    Console.WriteLine(ara[y]);
                    count = count + 1;
                }
            Console.WriteLine($"Итого элементов абсолютная величина которых больше 7: {count}");
            Console.ReadKey();
            int[] A = new int[50];
            for (int t = 0; t < ara.Length; t++)
                if (t % 2 == 0)
                {
                    A[t] = ara[t] * ara[t];
                }
                else
                    A[t] = 0;
            Console.WriteLine("Новый массив:");
            for (int f = 0; f < A.Length; f++)
                Console.WriteLine(A[f]);
            Console.ReadKey();
        }
    }
}
