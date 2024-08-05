using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(year);

            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Високосный год");
            }
            else
            {
                Console.WriteLine("Не Високосный год");
            }
        }
    }
}
