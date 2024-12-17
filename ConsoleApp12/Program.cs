using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
  
    
        static void Main()
        {
            Console.Write("Введите номер месяца (1-12): ");
            int month = int.Parse(Console.ReadLine());

            string season;
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Зима";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Весна";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Лето";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Осень";
                    break;
                default:
                    season = "Неверный номер месяца!";
                    break;
            }

            Console.WriteLine("Время года: " + season);
            Console.ReadKey();
        }
    }
}
