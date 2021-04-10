using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Не соизволите ли вы набрать число,госопдин???");
            Console.WriteLine("Ввидите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввидите число y");
            double y = Convert.ToDouble(Console.ReadLine());
            double xy = -5 * Math.Sqrt(x + Math.Sqrt(y));
            Console.WriteLine("Решебник ответ." + xy);

            Console.ReadKey();
        }
    }
}
5