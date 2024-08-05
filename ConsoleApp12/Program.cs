using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;



            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    a = i * j;
                    if (a >= 10) {Console.Write("    " + a); }
                    else {Console.Write("     " + a); }
                }
                Console.WriteLine("");
            }
        }
    }
}
