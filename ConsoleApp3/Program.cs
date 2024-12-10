using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        // Вспомогательный метод для нахождения минимального из двух чисел
        public static int MinOfTwo(int a, int b)
        {
            return a < b ? a : b; // Возвращает меньшее из двух чисел
        }

        // Основной метод для нахождения минимального из трёх чисел
        public static int MinOfThree(int a, int b, int c)
        {
            // Используем метод MinOfTwo для сравнения трёх чисел
            return MinOfTwo(MinOfTwo(a, b), c);
        }

        static void Main(string[] args)
        {
            // Пример чисел
            int num1 = 12;
            int num2 = 7;
            int num3 = 20;

            // Нахождение минимального числа
            int result = MinOfThree(num1, num2, num3);

            // Вывод результата
            Console.WriteLine($"Минимальное из чисел {num1}, {num2} и {num3} = {result}");
            {
            }
        }
    }
}
