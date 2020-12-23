using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChernobylApp2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число a: ");
                ulong a = ulong.Parse(Console.ReadLine());
                Console.WriteLine("Введите число b: ");
                ulong b = ulong.Parse(Console.ReadLine());
                Console.WriteLine("Введите число c: ");
                ulong c = ulong.Parse(Console.ReadLine());
                Console.WriteLine("Введите число d: ");
                ulong d = ulong.Parse(Console.ReadLine());
                if ((a < c) && (b < d))
                    Console.WriteLine("Можно");
                else if ((a < d) && (b < c)) ;
                else Console.WriteLine("Не можно");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
