using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    internal class Program
    {
        static int LeapYearsBetween(int start, int end)
        {
            System.Diagnostics.Debug.Assert(start < end);
            return LeapYearsBefore(end) - LeapYearsBefore(start + 1);
        }

        static int LeapYearsBefore(int year)
        {
            System.Diagnostics.Debug.Assert(year > 0);
            year--;
            return (year / 4) - (year / 100) + (year / 400);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            int z = LeapYearsBetween(a, b);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
