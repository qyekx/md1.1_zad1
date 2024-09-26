using System;

class Program
{
    // Функция для создания массива
    static int[] CreateArray(int targetSum)
    {
        Random random = new Random();
        int currentSum = 0;
        int count = 0;
        int[] array = new int[100]; // Создаем массив фиксированной длины 100

        // Добавляем случайные значения от 1 до 9 в массив
        for (int i = 0; i < array.Length; i++)
        {
            int randomValue = random.Next(1, 10);

            // Проверяем, что сумма не превышает целевую
            if (currentSum + randomValue <= targetSum)
            {
                array[count] = randomValue; // Добавляем элемент в массив
                currentSum += randomValue; // Увеличиваем текущую сумму
                count++; // Увеличиваем счетчик элементов
            }
            else
            {
                break; // Останавливаем цикл, если добавление элемента превысит целевую сумму
            }
        }

        // Создаем новый массив с точным количеством элементов
        int[] resultArray = new int[count];
        Array.Copy(array, resultArray, count); // Копируем элементы в результативный массив
        return resultArray;
    }

    // Функция для вывода массива
    static void PrintArray(int[] array)
    {
        Console.WriteLine("Элементы массива:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // Ввод целевой суммы от пользователя
        Console.WriteLine("Введите целое число (максимальная сумма):");
        int targetSum = int.Parse(Console.ReadLine());

        // Создание массива с минимальным количеством элементов
        int[] resultArray = CreateArray(targetSum);

        // Вывод результата
        Console.WriteLine($"Минимальное количество элементов: {resultArray.Length}");
        PrintArray(resultArray);
    }
}
