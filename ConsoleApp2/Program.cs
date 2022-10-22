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
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Квадраты чисел от 1 до {0}:", n);
            for (uint i = 1, sqr = 0; i <= n; i++)
                Console.WriteLine("{0}^2 = {1}", i, sqr += i * 2 - 1);
            Console.ReadKey();
        }
    }
}
