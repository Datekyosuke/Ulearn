using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string a = Console.ReadLine();
            char[] charA = a.ToCharArray();
            Array.Reverse(charA);
            string b = new string(charA);

            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
