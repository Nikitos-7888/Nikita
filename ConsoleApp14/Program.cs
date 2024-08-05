using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(year);

            if (year <= 12)
            {
                Console.WriteLine("Ребенок");
            }
            else if (year >= 13 && year <= 17)
            {
                Console.WriteLine("Подросток");
            }
            else if (year >= 18 && year <= 64)
            {
                Console.WriteLine("Взрослый");
            }
            else if (year >= 65)
            {
                Console.WriteLine("Пожилой");
            }
        }
    }
}
