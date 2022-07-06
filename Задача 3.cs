using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время: ");
            int time = Convert.ToInt32(Console.ReadLine());
            int gradus;
            if (time >= 12)
            {
                time -= 12;
                if (time > 6)

                    gradus = (12 - time) * 30;
                else gradus = time * 30;
            }
            else
            {
                if (time > 6)
                    gradus = (12 - time) * 30;
                else gradus = time * 30;
            }
            Console.WriteLine(gradus);
            Console.ReadKey();
        }
    }
}
