using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zd_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите  порядковый номер месяца: ");
            int N = Convert.ToInt16(Console.ReadLine());

            Console.Write("Введите  среднюю температуру месяца: ");
            int t = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(((N == 1) || (N == 2) || (N == 12)) & (t > 0) ? "Дождливая зима" : "___" ) ;

            Console.ReadLine();
        }
    }
}
