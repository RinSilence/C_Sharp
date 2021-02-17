using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zd_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String name1 = "апельсины", name2 = "яблоки   ", name3 = "молоко   ",
                adress = "г.Архангельск, ул.Урицкого, д.45", bank = "ПАО СБЕРБАНК";

            float kol_1 = 1.2f, kol_2 = 1.5f, kol_3 = 1, sum_1 = 87.9f, sum_2 = 109, sum_3 = 54.99f;

            double n_checue = 1055, n_termin = 21939202, merchant = 141003002811;

            Console.WriteLine("__________Кассовый чек__________");
            Console.WriteLine(name1 + "= " + kol_1 +" x " + sum_1 + "  = " + (kol_1*sum_1));
            Console.WriteLine(name2 + "= " + kol_2 + " x " + sum_2 + "  = " + (kol_2 * sum_2));
            Console.WriteLine(name3 + "= " + kol_3 + " x " + sum_3 + "  = " + (kol_3 * sum_3));
            Console.WriteLine("________________________________");
            Console.WriteLine("_____________Макси______________");
            Console.WriteLine(adress);
            Console.WriteLine( DateTime.Now.ToShortDateString() + "           ЧЕК  " + n_checue);
            Console.WriteLine(bank + "            Оплата" );
            Console.WriteLine("Терминал:               " + n_termin );
            Console.WriteLine("Мерчант:            " + merchant);
            Console.WriteLine("...");

            Console.ReadLine();
        }
    }
}
