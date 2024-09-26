using System;

class Program
{
    static void Main(string[] args)
    {
        // Просим пользователя ввести первое число
        Console.WriteLine("Введите первое целое число:");
        int number1;

        // Проверяем корректность ввода первого числа
        while (!int.TryParse(Console.ReadLine(), out number1))
        {
            Console.WriteLine("Пожалуйста, введите корректное целое число.");
        }

        // Просим пользователя ввести второе число
        Console.WriteLine("Введите второе целое число:");
        int number2;

        // Проверяем корректность ввода второго числа
        while (!int.TryParse(Console.ReadLine(), out number2))
        {
            Console.WriteLine("Пожалуйста, введите корректное целое число.");
        }

        // Вычисляем сумму двух чисел
        int sum = number1 + number2;

        // Выводим результат на экран
        Console.WriteLine($"Сумма {number1} и {number2} равна {sum}");
    }
}
