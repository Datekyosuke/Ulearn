using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            int y = int.Parse(Console.ReadLine());
            int z = (N - 1) / x + (N - 1) / y - (N - 1)/(x*y);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
