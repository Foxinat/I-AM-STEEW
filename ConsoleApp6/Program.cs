using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        // Статический метод для расчета значения X
        public static double CalculateX()
        {
            // Вычисление частей выражения
            double part1 = 15 + Math.Sqrt(8) / 8;
            double part2 = Math.Sqrt(15) + 6;
            double part3 = Math.Sqrt(12) / 12;
            double part4 = Math.Sqrt(6) + 7;
            double part5 = Math.Sqrt(21) / 21;
            double part6 = Math.Sqrt(7);

            // Суммирование всех частей
            double result = part1 + part2 + part3 + part4 + part5 + part6;
            return result;
        }

        static void Main(string[] args)
        {
            // Вызов метода CalculateX
            double x = CalculateX();

            // Вывод результата
            Console.WriteLine($"Значение X = {x:F3}");
            {
            }
        }
    }
}