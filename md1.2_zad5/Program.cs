using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Вводим K
        Console.WriteLine("Введите размер массива K:");
        int K = int.Parse(Console.ReadLine());

        // Инициализируем массив и заполняем случайными буквами
        char[] array = new char[K];
        Random random = new Random();

        string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string consonants = "бвгджзклмнпрстфхцчшщ";

        for (int i = 0; i < K; i++)
        {
            array[i] = alphabet[random.Next(alphabet.Length)];
        }

        // Выводим исходный массив
        Console.WriteLine("Массив букв:");
        Console.WriteLine(string.Join(" ", array));

        // Создаем массив согласных
        char[] consonantArray = array.Where(c => consonants.Contains(c)).ToArray();

        // Выводим массив согласных
        Console.WriteLine("Массив согласных букв:");
        Console.WriteLine(string.Join(" ", consonantArray));
    }
}
