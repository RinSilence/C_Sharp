using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zd_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите  порядковый номер месяца: ");
            byte N = Convert.ToByte(Console.ReadLine());

            string month = "не существует";

            switch (N)
            {
                case 1:
                    month = "Январь";
                    break;

                case 2:
                    month = "Февраль";
                    break;

                case 3:
                    month = "Март";
                    break;

                case 4:
                    month = "Апрель";
                    break;

                case 5:
                    month = "Май";
                    break;

                case 6:
                    month = "Июнь";
                    break;

                case 7:
                    month = "Июль";
                    break;

                case 8:
                    month = "Август";
                    break;

                case 9:
                    month = "Сентябрь";
                    break;

                case 10:
                    month = "Октябрь";
                    break;

                case 11:
                    month = "Ноябрь";
                    break;

                case 12:
                    month = "Декабрь";
                    break;
            }

            Console.WriteLine("Месяц с данным порядковым номером - " + month);

            Console.ReadLine();
        }
    }
}
