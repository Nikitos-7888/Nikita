using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число 1");
            int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число 2");
            //int b = int.Parse(Console.ReadLine());

            if (a >= 90)
            {
                Console.WriteLine("Оценка A");
            }
            if (a >= 80 && a < 90)
            {
                Console.WriteLine("Оценка B");
            }
            if (a >= 70 && a < 80)
            {
                Console.WriteLine("Оценка C");
            }
            if (a >= 60 && a < 70)
            {
                Console.WriteLine("Оценка D");
            }
            if (a < 60)
            {
                Console.WriteLine("Оценка F");
            }
        }
    }
}
