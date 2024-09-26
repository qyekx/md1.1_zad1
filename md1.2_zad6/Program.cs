using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Инициализируем массив из 10 элементов и заполняем случайными числами
        double[] array = new double[10];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.NextDouble() * 20 - 10; // Диапазон [-10, 10)
        }

        // Выводим исходный массив
        Console.WriteLine("Массив:");
        Console.WriteLine(string.Join(", ", array.Select(x => x.ToString("F2"))));

        // Формируем массив индексов
        int[] indices = Enumerable.Range(0, array.Length)
                                  .OrderBy(i => array[i])
                                  .ToArray();

        // Выводим массив индексов
        Console.WriteLine("Индексы элементов в порядке возрастания значений:");
        Console.WriteLine(string.Join(", ", indices));
    }
}
