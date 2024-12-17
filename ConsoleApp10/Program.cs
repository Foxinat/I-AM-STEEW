using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {


        static void Main()
        {
            Console.Write("Введите номер дня недели (1-7): ");
            int n = int.Parse(Console.ReadLine());

            string day;
            switch (n)
            {
                case 1:
                    day = "Понедельник";
                    break;
                case 2:
                    day = "Вторник";
                    break;
                case 3:
                    day = "Среда";
                    break;
                case 4:
                    day = "Четверг";
                    break;
                case 5:
                    day = "Пятница";
                    break;
                case 6:
                    day = "Суббота";
                    break;
                case 7:
                    day = "Воскресенье";
                    break;
                default:
                    day = "Неверный номер дня недели!";
                    break;
            }

            Console.WriteLine("День недели: " + day);
        }
    }
}

        
       


