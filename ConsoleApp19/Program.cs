using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод слова 'Привет!' 5 раз (цикл с условием):");
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("Привет!");
                count++;
            }

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
        }
    }
}
