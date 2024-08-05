using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число 1");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(a);

            int integerPart = (int)a;
            Console.WriteLine(integerPart);

        }


    }
}
