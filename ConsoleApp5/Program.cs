using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        // Статический метод для расчета значения Y
        public static double CalculateY()
        {
            // Вычисление отдельных частей выражения
            double part1 = Math.Sqrt(7) + 7 / 3.0;
            double part2 = Math.Sqrt(11) + 11 / 3.0;
            double part3 = Math.Sqrt(15) + 15 / 3.0;

            // Суммирование 
            double result = part1 + part2 + part3;
            return result;
        }

        static void Main(string[] args)
        {
            // Вызов метода CalculateY
            double y = CalculateY();

            // Вывод результата
            Console.WriteLine($"Значение Y = {y:F3}");
            {
            }
        }
    }
}
