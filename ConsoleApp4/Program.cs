using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число 1");
            int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число 2");
            //int b = int.Parse(Console.ReadLine());

            if (a >= 0 && a % 2 == 0)
            {
                Console.WriteLine("Число положительное и четное");
            }
            if (a < 0 || a % 2 != 0)
            {
                Console.WriteLine("Число отрицательное или не четное");
            }
        }
    }
}
