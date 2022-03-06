using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Раздел 3.4, Табулирование функции, высокий уровень, вариант 8.");
            double h = 0.15, fx = 0;
            for (double i = -1; i <= 2; i += h)
            {
                if (i > 0)
                {
                    fx = Math.Log(Math.Pow(i, 1.5));
                    Console.WriteLine($"Аргумент = {i} => значение = {fx}");
                }
                else
                {
                    for (double k = 1; k <= 9; k++)
                    {
                        fx += Math.Pow(k, (Math.Pow(i, 2)));
                    }
                    Console.WriteLine($"Аргумент = {i} => значение = {fx}");
                }
            }
            Console.ReadKey();
        }
    }
}
