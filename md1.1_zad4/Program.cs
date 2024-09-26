using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Создаем объект для генерации случайных чисел
        Random random = new Random();

        // Создаем массив из 15 случайных чисел в диапазоне от -50 до 50
        int[] array = new int[15];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-50, 51); // Случайные числа от -50 до 50 включительно
        }

        // Выводим массив на экран
        Console.WriteLine("Массив случайных чисел:");
        Console.WriteLine(string.Join(", ", array));

        // Фильтруем только положительные числа и вычисляем среднее
        var positiveNumbers = array.Where(num => num > 0);
        double average = positiveNumbers.Any() ? positiveNumbers.Average() : 0;

        // Выводим результат
        if (positiveNumbers.Any())
        {
            Console.WriteLine($"Среднее значение всех положительных чисел: {average:F2}");
        }
        else
        {
            Console.WriteLine("В массиве нет положительных чисел.");
        }
    }
}
