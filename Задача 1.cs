using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа а:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите числа b:");
            double b = Convert.ToDouble(Console.ReadLine());
            a = -a - b;
            b = -a - b;
            a = -a - b;
            Console.WriteLine($"Число а: {a}");
            Console.WriteLine($"Число b: {b}");
            Console.ReadLine();
        }
    }
}
