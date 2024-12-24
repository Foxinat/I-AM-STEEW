using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Горизонтальная строка из 18 символов
            Console.ForegroundColor = ConsoleColor.Green; // Устанавливаем цвет текста
            Console.WriteLine("а) Горизонтальная строка из 18 символов:");
            for (int i = 0; i < 18; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();

            Console.ResetColor(); // Сброс цвета текста

            // Вертикальная строка из 25 символов
            Console.ForegroundColor = ConsoleColor.Yellow; // Устанавливаем цвет текста
            Console.WriteLine("\nб) Вертикальная строка из 25 символов:");
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("|");
            }

            Console.ResetColor(); // Сброс цвета текста

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
        }
    }
}
