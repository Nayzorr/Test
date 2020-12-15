using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int n = int.Parse(Console.ReadLine());
            CountTo(n);
        }
        static void CountTo(int num)
        {
            for(int i = 0; i <= num; i++)
            {
                Console.Write(" "+i);
                
            }
            Console.WriteLine();
        }

    }
}
