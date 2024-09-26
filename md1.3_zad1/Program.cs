using System;

class Program
{
    // Метод для вычисления наибольшего общего делителя (НОД)
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        // Ввод дроби
        Console.WriteLine("Введите числитель (неотрицательное целое число):");
        int numerator = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите знаменатель (положительное целое число):");
        int denominator = int.Parse(Console.ReadLine());

        // Вычисление НОД
        int gcd = GCD(numerator, denominator);

        // Сокращение дроби
        numerator /= gcd;
        denominator /= gcd;

        Console.WriteLine($"Сокращенная дробь: {numerator}/{denominator}");
    }
}
