using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            int b = a * 10;
            Console.WriteLine(b);
        }
    }
}
