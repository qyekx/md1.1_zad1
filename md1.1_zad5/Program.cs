using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = IsPrime(number); // Проверяем, является ли число простым

        if (isPrime)
            Console.WriteLine($"{number} является простым числом.");
        else
            Console.WriteLine($"{number} не является простым числом.");
    }

    // Метод для проверки, является ли число простым
    static bool IsPrime(int n)
    {
        if (n <= 1) return false; // Числа меньше или равные 1 не являются простыми

        for (int i = 2; i <= Math.Sqrt(n); i++) // Проверяем делимость до квадратного корня из n
        {
            if (n % i == 0) return false; // Если n делится на i, то это не простое число
        }
        return true; // Если не найдено делителей, число простое
    }
}
