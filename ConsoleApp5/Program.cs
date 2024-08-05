using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число 1");
            int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число 2");
            //int b = int.Parse(Console.ReadLine());


            if (a % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }
        }
    }
}
