using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку");
            string a = Console.ReadLine();
            Console.WriteLine(a);

            Console.WriteLine("Введите число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(b);

            Console.WriteLine("Введите число с плавующей точкой");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(c);

            Console.WriteLine("Введите символ");
            char d = char.Parse(Console.ReadLine());
            Console.WriteLine(d);

            Console.WriteLine("Введите логическое значение");
            bool e = bool.Parse(Console.ReadLine());
            Console.WriteLine(e);

        }
    }
}
