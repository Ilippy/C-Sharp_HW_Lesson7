// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        int[,] array = CreateRandomArray(Numbers.EnterNumber("Введите количество строк"),
            Numbers.EnterNumber("Введите количество столбцов"), 1, 10);
        Console.Clear();
        PrintArray(array);
        int indexOfArray = Numbers.EnterNumber("Введите порядковый номер числа, которого вы хотите найти в массиве");
        System.Console.WriteLine($"{indexOfArray} -> {GetNumberInArrayByIndex(array, indexOfArray)}");
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

    static string GetNumberInArrayByIndex(int[,] array, int index)
    {
        if (index < 1 || index > array.Length)
            return "такого числа в массиве нет";
        else
        {
            int row = (index - 1) / array.GetLength(1);
            int column = (index - 1) % array.GetLength(1);
            return $"{array[row, column]}";
        }
    }
}