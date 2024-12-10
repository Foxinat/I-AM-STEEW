using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        // Функция для вычисления площади треугольника по координатам вершин
        public static double TriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
        }

        static void Main(string[] args)
        {
            // Координаты вершин пятиугольника
            double x1 = 0, y1 = 0;
            double x2 = 4, y2 = 0;
            double x3 = 5, y3 = 3;
            double x4 = 3, y4 = 5;
            double x5 = 1, y5 = 3;

            // Площадь пятиугольника как сумма трёх треугольников
            double area1 = TriangleArea(x1, y1, x2, y2, x3, y3);
            double area2 = TriangleArea(x1, y1, x3, y3, x4, y4);
            double area3 = TriangleArea(x1, y1, x4, y4, x5, y5);

            double totalArea = area1 + area2 + area3;

            // Вывод результата
            Console.WriteLine($"Площадь пятиугольника: {totalArea:F3}");
            {
            }
        }
    }
}