using System;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8 вариант. Раздел 3.1, высокий уровень.\nЧисло k вводим с клавиатуры");
            double Pp = 1, Ps = 0, P;
            int k, j, i;
            do
            {
                Console.Write("Введите положительное число (если нет, то введите еще раз):");
                k = Convert.ToInt32(Console.ReadLine());
            }
            while (k <= 0);

            for (j = -1; j <= k; j++)
            {
                if (j != 4)
                {
                    double e = (j - Math.Pow(j, 2) * k) / (j - 4);
                    if (e != 0)
                    {
                        Pp = Pp * e;
                    }
                }
            }
            for (i = -1; i <= (k + 2); i++)
            {
                if (i != 7)
                {
                    double e = (Math.Pow(Math.Abs(i - 5), 1 / 3)) / (Math.Abs(i - 7));
                    Ps += e;
                }
            }
            P = Pp * Ps;
            Console.WriteLine("Ответ равен " + P);
            Console.ReadKey();
        }
    }
}
