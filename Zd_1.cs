using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zd_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите минимальную суточную температуру: ");
            double t_min = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите минимальную суточную температуру: ");
            double t_max = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Среднесуточная температура = " + ((t_min+t_max)/2));

            Console.ReadLine();
        }
    }
}
