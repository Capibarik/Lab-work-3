using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 общая задача, 3.\nРешить задачу, используя цикл do…while. Даны положительные числа A и B(A > B).На отрезке длины A размещено максимально возможное количество отрезков длины B(без наложений).Не используя операции умножения и деления, найти длину незанятой части отрезка A.");
            Random rnd = new Random();
            double a = rnd.Next(10, (int)Math.Pow(10, 4)) / (rnd.NextDouble() * 10);
            double b = rnd.Next(10, (int)a) / (rnd.NextDouble() * 10);
            do
            {
                a = a - b;
            }
            while (a > b);
            double ocp = a;
            Console.WriteLine($"Ответ {ocp}");
            Console.ReadKey();
        }
    }
}
