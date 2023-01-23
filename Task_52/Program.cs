// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System.Linq;
using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        int[,] array = CreateRandomArray(Numbers.EnterNumber("Введите количество строк в пределах[1,20]", 1, 20),
            Numbers.EnterNumber("Введите количество столбцов в пределах[1,20]", 1, 20), 1, 10);
        Console.Clear();
        PrintArray(array);
        Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", GetAverageNumbersInColumns(array))}");
    }

    static int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
    {
        int[,] array = new int[rows, columns];
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = random.Next(minValue, maxValue + 1);
        return array;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j]} ");
            Console.WriteLine();
        }
    }

    static double[] GetAverageNumbersInColumns(int[,] array)
    {
        double[] result = new double[array.GetLength(1)];
        double sumNumbersInColumn;
        for (int j = 0; j < result.Length; j++)
        {
            sumNumbersInColumn = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                sumNumbersInColumn += array[i, j];
            result[j] = Math.Round(sumNumbersInColumn / array.GetLength(0), 2);
        }

        return result;
    }
}