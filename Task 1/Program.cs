using System;
using static System.Console;

namespace Task_1
{
    internal class Program
    {
        /// <summary>
        /// Случайная матрица
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Write("Введите количество строк:");
            byte m = byte.Parse(ReadLine());
            Write("Введите количество столбцов:");
            byte n = byte.Parse(ReadLine());

            short[,] a = new short[m, n];
            Random r = new Random();
            long s = 0;

            WriteLine($"Матрица размером {m} на {n}:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = (short)r.Next(short.MinValue, short.MaxValue);
                    Write($"{a[i, j],7} ");
                    s += a[i, j];
                }
                WriteLine();
            }

            WriteLine($"Сумма всех элементов матрицы: {s}");

            ReadKey();

        }
    }
}
