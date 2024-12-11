using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // Статический метод для преобразования метров и сантиметров в общее количество сантиметров
        public static int Centimeters(int m, int c)
        {
            // 1 метр = 100 сантиметров
            return m * 100 + c;
        }

        static void Main()
        {
            // Пример 1: 2 метра и 4 сантиметра
            int result1 = Centimeters(2, 4);
            Console.WriteLine("2 метра 4 сантиметра = " + result1 + " сантиметра");

            // Пример 2: 15 метров и 27 сантиметров
            int result2 = Centimeters(15, 27);
            Console.WriteLine("15 метров 27 сантиметров = " + result2 + " сантиметров");
            {
            }
        }
    }
}
