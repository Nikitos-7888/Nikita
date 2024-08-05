using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 0;

            while (a < 50)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                a++;
            }
        }
    }
}
