using System;

class Program
{
    static void Main()
    {
        // Инициализируем массив из 10 элементов
        int[] array = new int[10];
        Random random = new Random();

        // Заполняем массив случайными числами
        Console.WriteLine("Массив из 10 случайных чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Вводим целое число
        Console.WriteLine("Введите целое число для замены максимального элемента:");
        int newValue = int.Parse(Console.ReadLine());

        // Находим индекс максимального элемента
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
                maxIndex = i;
        }

        // Заменяем максимальный элемент введенным числом
        array[maxIndex] = newValue;

        // Выводим измененный массив
        Console.WriteLine("Измененный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
}
