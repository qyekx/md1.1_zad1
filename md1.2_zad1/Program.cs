using System;

class Program
{
    static void Main()
    {
        // Вводим размер массива
        Console.WriteLine("Введите размер массива N:");
        int N;

        // Проверяем, что введен корректный размер массива
        while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
        {
            Console.WriteLine("Введите положительное целое число для размера массива:");
        }

        // Инициализируем массив и вводим его элементы
        double[] array = new double[N];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < N; i++)
        {
            // Проверяем, что введено корректное число
            while (!double.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.WriteLine($"Элемент {i + 1} некорректен, введите число заново:");
            }
        }

        // Находим максимальный по модулю элемент
        double maxAbs = Math.Abs(array[0]);
        for (int i = 1; i < N; i++)
        {
            if (Math.Abs(array[i]) > maxAbs)
            {
                maxAbs = Math.Abs(array[i]);
            }
        }

        // Проверяем, что максимальный элемент не равен нулю, чтобы избежать деления на ноль
        if (maxAbs == 0)
        {
            Console.WriteLine("Все элементы массива равны нулю. Нормировка невозможна.");
        }
        else
        {
            // Нормируем массив (делим каждый элемент на максимальный по модулю)
            for (int i = 0; i < N; i++)
            {
                array[i] /= maxAbs;
            }

            // Выводим измененный массив
            Console.WriteLine("Нормированные элементы массива:");
            foreach (double element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
