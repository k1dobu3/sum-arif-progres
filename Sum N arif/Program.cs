using System;

namespace Sum_N_arif
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1;
            int sum = 0;

            Console.WriteLine("Введите число, сумму арифметических чисел которого нужно посчитать:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число, до которого будет идти прогрессия:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите коэф. арифметической прогрессии:");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i += c)
            {
                sum1 = i;
                sum += sum1;
            }
            Console.WriteLine($"Сумма {b} членов арифметической прогрессии равна {sum}.");
        }
    }
}
