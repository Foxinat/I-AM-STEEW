using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        // Функция для нахождения минимального из двух чисел
        public static int Min(int x, int y)
        {
            return x < y ? x : y; // Возвращает меньшее из двух чисел
        }

        static void Main(string[] args)
        {
            // Исходные значения
            int a = 5;
            int b = 8;

            // Вычисление значения z
            int z = Min(2 * a, b + a) + Min(2 * a - b, b);

            // Вывод результата
            Console.WriteLine($"Значение z = {z}");
            {
            }
        }
    }
}