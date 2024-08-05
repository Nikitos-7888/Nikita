using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine(c);


            Console.WriteLine("Введите число 1");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int b1 = int.Parse(Console.ReadLine());
            int c1 = a1 - b1;
            Console.WriteLine(c1);


            Console.WriteLine("Введите число 1");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int b2 = int.Parse(Console.ReadLine());
            int c2 = a2 * b2;
            Console.WriteLine(c2);


            Console.WriteLine("Введите число 1");
            int a3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int b3 = int.Parse(Console.ReadLine());
            int c3 = a3 / b3;
            Console.WriteLine(c3);

        }
    }
}
