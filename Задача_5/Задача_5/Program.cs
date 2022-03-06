using System;

namespace Задача__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Раздел 3.2, 8 вариант, высокий уровень. Написать программу поиска произведения последовательности чисел, вводимых с клавиатуры, предшествующих первому введеному отрицательному числу.\nЕсли первым будет введено отрицательное число, то ответ будет равно 1");
            double a, S = 1;
            do
            {
                Console.Write("Введите число:");
                a = Convert.ToDouble(Console.ReadLine());
                if (a > 0)
                {
                    S = S * a;
                }
            }
            while (a > 0);
            Console.WriteLine("Ответ " + S);
            Console.ReadLine();
        }
    }
}
