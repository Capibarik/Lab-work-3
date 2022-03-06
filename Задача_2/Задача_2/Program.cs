using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Спортсмен-лыжник начал тренировки, пробежав в первый день 10 км. Каждый следующий день он увеличивал длину пробега на P процентов от пробега предыдущего дня (P — вещественное, 0 < P < 50). По данному P определить, после какого дня суммарный пробег лыжника за все дни превысит 200 км, и вывести найденное количество дней K (целое) и суммарный пробег S (вещественное число).");
            double a1 = 10, p = 0, S = 0;
            int k = 0;
            do
            {
                Console.Write("Введите количество процентов от 0 до 50 не включительно:");
                p = Convert.ToDouble(Console.ReadLine());
            }
            while ((p <= 0) | (p >= 50));
            while (S <= 200)
            {
                a1 = a1 * (1 + p / 100);
                S += a1;
                k++;
            }
            Console.WriteLine($"Суммарный пробег лыжника за {k} дней составит {S} км.");
            Console.ReadLine();
        }
    }
}
