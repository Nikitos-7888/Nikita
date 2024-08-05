using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите число 2");
            //int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i);
            }
        }
     }
}
