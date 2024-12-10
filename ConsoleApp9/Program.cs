using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        // Функция для вычисления длины стороны треугольника
        public static double SideLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            // Координаты вершин треугольника
            double x1 = 0, y1 = 0;
            double x2 = 4, y2 = 0;
            double x3 = 2, y3 = 3;

            // Длины сторон
            double a = SideLength(x1, y1, x2, y2);
            double b = SideLength(x2, y2, x3, y3);
            double c = SideLength(x3, y3, x1, y1);

            // Проверка типа треугольника
            if (Math.Abs(a - b) < 1e-9 && Math.Abs(b - c) < 1e-9)
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else if (Math.Abs(a - b) < 1e-9 || Math.Abs(b - c) < 1e-9 || Math.Abs(c - a) < 1e-9)
            {
                Console.WriteLine("Треугольник равнобедренный");
            }
            else if (Math.Abs(a * a + b * b - c * c) < 1e-9 ||
                     Math.Abs(b * b + c * c - a * a) < 1e-9 ||
                     Math.Abs(c * c + a * a - b * b) < 1e-9)
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            else
            {
                Console.WriteLine("Треугольник обычный");
                {
                }
            }
        }
    }
}
