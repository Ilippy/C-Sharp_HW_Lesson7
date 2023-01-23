// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

internal partial class Program
{
    private static void Main(string[] args)
    {
        int[,] array = CreateRandomArray(5, 8, 0, 10);
        PrintArray(array);
        System.Console.WriteLine();
        Console.WriteLine($"Сумма главной диагонали {SumMainDiagonal(array)}");
    }
    static int SumMainDiagonal(int[,] array)
    {
        int sum = 0;
        int size = Math.Min(array.GetLength(0), array.GetLength(1));
        for (int i = 0; i < size; i++)
            sum += array[i, i];
        return sum;
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

}