using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {

    
        static void Main()
        {
            Console.Write("Введите первую букву предмета (ф, м, и, г, б): ");
            char letter = char.ToLower(Console.ReadKey().KeyChar); // Считываем символ с клавиатуры
            Console.WriteLine(); // Для новой строки

            string subject;
            switch (letter)
            {
                case 'ф': subject = "Физика"; break;
                case 'м': subject = "Математика"; break;
                case 'и': subject = "История"; break;
                case 'г': subject = "География"; break;
                case 'б': subject = "Биология"; break;
                default: subject = "Неизвестный предмет"; break;
            }

            Console.WriteLine("Название предмета: " + subject);
            Console.ReadKey();
        }
    }
 }
