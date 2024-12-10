using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        // Функция для определения максимума из двух чисел
        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        static void Main(string[] args)
        {
            // Массив из 8 чисел
            double[] numbers = { 12, 5, 8, 19, 24, 3, 17, 11 };

            // Поиск максимального числа
            double maxNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                maxNumber = Max(maxNumber, numbers[i]);
            }

            // Вывод результата
            Console.WriteLine($"Максимальное число: {maxNumber}");
            {
            }
        }
    }
}