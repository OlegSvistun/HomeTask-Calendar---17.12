using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Console.WriteLine("Введіть номер дня тижня (1-7):");
                int dayNumber = Convert.ToInt32(Console.ReadLine());

                switch (dayNumber)
                {
                    case 1:
                        Console.WriteLine("Понеділок");
                        break;
                    case 2:
                        Console.WriteLine("Вівторок");
                        break;
                    case 3:
                        Console.WriteLine("Середа");
                        break;
                    case 4:
                        Console.WriteLine("Четвер");
                        break;
                    case 5:
                        Console.WriteLine("П'ятниця");
                        break;
                    case 6:
                        Console.WriteLine("Субота");
                        break;
                    case 7:
                        Console.WriteLine("Неділя");
                        break;
                    default:
                        Console.WriteLine("Невірне значення. Введіть число від 1 до 7.");
                        break;
                }

                // Додаємо паузу перед завершенням програми, щоб можна було прочитати результат
                Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
                Console.ReadKey();
        }
    }
}
