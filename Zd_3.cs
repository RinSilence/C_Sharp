using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zd_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
             int a = Convert.ToInt16(Console.ReadLine());

            if ( a % 2 == 0)
            {
                Console.WriteLine("Число " + a + " - чётное. ");
            }
            else
            {
                Console.WriteLine("Число " + a + " - нечётное. ");
            }
            
            Console.ReadLine();
        }
    }
}
