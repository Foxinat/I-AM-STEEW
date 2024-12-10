using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        // Статический метод для вычисления общего количества копеек
        public static int Kop(int r, int k)
        {
            return r * 100 + k; // 1 рубль = 100 копеек
        }

        static void Main(string[] args)
        {
            // Пример использования метода
            int result1 = Kop(5, 24);  // 5 руб. 24 коп.
            int result2 = Kop(15, 7);  // 15 руб. 7 коп.

            // Вывод результатов
            Console.WriteLine($"5 руб. 24 коп. = {result1} копеек");
            Console.WriteLine($"15 руб. 7 коп. = {result2} копеек");
            {
            }
        }
    }
}