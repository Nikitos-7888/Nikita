using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            int w = 1;
            for (int i = 1; i <= a; i++)
            {
                w = w * i;
            }
            Console.WriteLine(w);
        }
    }
}
