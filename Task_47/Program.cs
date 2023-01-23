// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        double[,] array = CreateRandomArray(Numbers.EnterNumber("Введить количество строк"),
            Numbers.EnterNumber("Введите количество столбцов"), 0, 10);
        PrintArray(array);
    }

    static double[,] CreateRandomArray(int rows, int columns, double minValue, double maxValue)
    {
        double[,] array = new double[rows, columns];
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = random.NextDouble() * (maxValue - minValue) + minValue;
        return array;
    }

    static void PrintArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j]:f2} ");
            Console.WriteLine();
        }
    }
}