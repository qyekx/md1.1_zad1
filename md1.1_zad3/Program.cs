using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя ввод строки
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        // Используем метод для переворота строки
        string reversedString = ReverseString(input);

        // Выводим перевернутую строку на экран
        Console.WriteLine($"Строка в обратном порядке: {reversedString}");
    }

    // Метод для переворота строки
    static string ReverseString(string str)
    {
        // Преобразуем строку в массив символов, переворачиваем и создаем новую строку
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
