using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Привет, {userName}, сегодня {DateTime.Now.ToShortDateString()}");

            Console.ReadLine();
        }
    }
}
