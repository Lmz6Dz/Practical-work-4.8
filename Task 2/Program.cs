using static System.Console;

namespace Task_2
{
    internal class Program
    {
        /// <summary>
        /// Наименьший элемент в последовательности
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Write("Введите длинну последовательности: ");
            byte m = byte.Parse(ReadLine());

            short[] p = new short[m];

            for (byte i = 0; i < m; i++)
            {
                Write($"Введите {i + 1} элемент последовательности: ");
                p[i] = short.Parse(ReadLine());
            }

            short min = short.MaxValue;

            for (byte i = 0; i < m; i++)
            {
                if (p[i] < min)
                {
                    min = p[i];
                }

            }

            Write($"Наименьшее число из последовательности: {min}");

            ReadKey();
        }
    }
}
