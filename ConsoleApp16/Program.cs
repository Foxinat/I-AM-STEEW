using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Вывод первых 10 натуральных чисел (цикл с условием):");
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("\n1. Вывод первых 10 натуральных чисел (цикл с параметром):");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
        }
    }
}

