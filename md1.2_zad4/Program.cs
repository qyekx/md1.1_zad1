using System;

class Program
{
    static void Main()
    {
        // Вводим K и диапазон A, B
        Console.WriteLine("Введите размер массива K:");
        int K = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите диапазон [A, B):");
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        // Инициализируем массив и заполняем случайными числами
        int[] array = new int[K];
        Random random = new Random();

        for (int i = 0; i < K; i++)
        {
            array[i] = random.Next(A, B);
        }

        // Выводим массив
        Console.WriteLine("Массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        // Находим индексы минимального и максимального элементов
        int minIndex = 0, maxIndex = 0;
        for (int i = 1; i < K; i++)
        {
            if (array[i] < array[minIndex]) minIndex = i;
            if (array[i] > array[maxIndex]) maxIndex = i;
        }

        // Выводим элементы между минимальным и максимальным (включая их)
        Console.WriteLine("Элементы между минимальным и максимальным:");
        for (int i = Math.Min(minIndex, maxIndex); i <= Math.Max(minIndex, maxIndex); i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
