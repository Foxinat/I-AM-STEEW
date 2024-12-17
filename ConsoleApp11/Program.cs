using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
     


    
        static void Main()
        {
            Console.Write("Введите номер месяца (1-12): ");
            int month = int.Parse(Console.ReadLine());

            string monthName;
            switch (month)
            {
                case 1: monthName = "Январь"; break;
                case 2: monthName = "Февраль"; break;
                case 3: monthName = "Март"; break;
                case 4: monthName = "Апрель"; break;
                case 5: monthName = "Май"; break;
                case 6: monthName = "Июнь"; break;
                case 7: monthName = "Июль"; break;
                case 8: monthName = "Август"; break;
                case 9: monthName = "Сентябрь"; break;
                case 10: monthName = "Октябрь"; break;
                case 11: monthName = "Ноябрь"; break;
                case 12: monthName = "Декабрь"; break;
                default: monthName = "Неверный номер месяца!"; break;
            }

            Console.WriteLine("Название месяца: " + monthName);
            Console.ReadKey();
        }
    }
}
   

