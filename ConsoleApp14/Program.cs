using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
   
        static void Main()
        {
            Console.Write("Введите признак транспортного средства (а, в, м, с, п): ");
            char transport = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            string maxSpeed;
            switch (transport)
            {
                case 'а': maxSpeed = "Автомобиль: до 200 км/ч"; break;
                case 'в': maxSpeed = "Велосипед: до 50 км/ч"; break;
                case 'м': maxSpeed = "Мотоцикл: до 250 км/ч"; break;
                case 'с': maxSpeed = "Самолет: до 900 км/ч"; break;
                case 'п': maxSpeed = "Поезд: до 300 км/ч"; break;
                default: maxSpeed = "Неизвестное транспортное средство"; break;
            }

            Console.WriteLine("Максимальная скорость: " + maxSpeed);
            Console.ReadKey();
        }
    }
 }

