using System;
using static System.Console;

namespace Task_3
{
    internal class Program
    {
        /// <summary>
        /// Игра «Угадай число»
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Random rand = new Random();

            int i = 0;
            int n;

            Write("Веедите максимальное целое число диапазона: ");
            int k = int.Parse(ReadLine());
            int chislo = rand.Next(0, k + 1);
            //Write("Введите число: ");
            do
            {
                i++;

                Write("Введите число: ");
                string s = ReadLine();

                if (s == string.Empty)
                {
                    Write($"загаданное число {chislo}");
                    ReadKey();
                    break;
                }
                else
                {

                    n = int.Parse(s);
                }


                if (n < chislo)
                {
                    WriteLine("Введенное число меньше загаданного. Попробуйте ещё раз");
                }
                else if (n > chislo)
                {
                    WriteLine("Введенное число больше загаданного. Попробуйте ещё раз");
                }
                else
                {
                    WriteLine($"Поздравляю, число угадано! Число попыток: {i}.");
                    ReadKey();
                    break;
                }
            }
            while (true);
        }
    }
}