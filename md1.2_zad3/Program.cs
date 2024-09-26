using System;

class Program
{
    static void Main()
    {
        // Вводим количество простых чисел
        Console.WriteLine("Введите количество простых чисел K:");
        int K = int.Parse(Console.ReadLine());

        int count = 0; // Счетчик найденных простых чисел
        int number = 2; // Начинаем с первого простого числа

        // Находим и выводим простые числа
        while (count < K)
        {
            if (IsPrime(number))
            {
                Console.Write(number + " ");
                count++;

                // Переход на новую строку после каждых 10 чисел
                if (count % 10 == 0)
                    Console.WriteLine();
            }
            number++;
        }
    }

    // Метод для проверки, является ли число простым
    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
