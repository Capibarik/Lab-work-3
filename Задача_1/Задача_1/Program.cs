using System;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано два целых числа A и B (A < B). Найти сумму квадратов всех целых чисел от А до B включительно.");
            double a = 0, b = 0;
            double d = 0;
            do
            {
                Console.Write("Введите а:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b (b > a):");
                b = Convert.ToDouble(Console.ReadLine());
            }
            while (b <= a);
            for (double i = a; i <= b; i++)
            {
                d += Math.Pow(i, 2); // d = d + Math.Pow(a, 2); 
            }
            Console.WriteLine($"Сумма всех квадратов целых чисел прин. [{a}; {b}] равна {d}");
            Console.ReadKey();

        }
    }
}

