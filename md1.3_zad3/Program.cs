using System;
using System.Linq;

class Program
{
    // Метод для генерации случайной матрицы
    static int[,] GenerateMatrix(int n)
    {
        Random rand = new Random();
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rand.Next(-50, 51); // Генерация случайных чисел от -50 до 50
            }
        }

        return matrix;
    }

    // Метод для сортировки строк матрицы по сумме их элементов
    static int[,] SortMatrixByRowSum(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        // Преобразуем строки матрицы в массивы для сортировки
        var sortedRows = Enumerable.Range(0, n)
            .Select(i => Enumerable.Range(0, n).Select(j => matrix[i, j]).ToArray())
            .OrderBy(row => row.Sum()) // Сортируем строки по сумме
            .ToArray();

        // Преобразуем обратно в двумерный массив
        int[,] sortedMatrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                sortedMatrix[i, j] = sortedRows[i][j];
            }
        }

        return sortedMatrix;
    }

    // Метод для вывода матрицы
    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите размер матрицы: ");
        int n = int.Parse(Console.ReadLine());

        // Генерация случайной матрицы
        int[,] matrix = GenerateMatrix(n);

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        // Сортировка строк по сумме их элементов
        int[,] sortedMatrix = SortMatrixByRowSum(matrix);

        Console.WriteLine("\nОтсортированная матрица:");
        PrintMatrix(sortedMatrix);
    }
}
