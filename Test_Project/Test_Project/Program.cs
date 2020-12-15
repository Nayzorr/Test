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
            //Console.Write("Введите размер массива: ");
            //int N = int.Parse(Console.ReadLine());
            //int[] arr = new int[N];
            //Fillarr(arr);
            //OutArr(arr);
            Console.WriteLine("Введите числа которые нужно сменить местами: ");
            Console.Write("a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            int b = int.Parse(Console.ReadLine());
            Swap<int>(ref a, ref b);
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
        }
        static void Fillarr(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }
        }
        static void OutArr(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
        }
        static void Swap<T>(ref T value1, ref T value2)
        {
            var t = value1;
            value1 = value2;
            value2 = t;
        }
    }
}
