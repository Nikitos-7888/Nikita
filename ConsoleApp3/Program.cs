using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("a равно b");
            }
            if (a > b)
            {
                Console.WriteLine("a больше b");
            }
            if (a < b)
            {
                Console.WriteLine("a меньше b");
            }
        }
    }
}
