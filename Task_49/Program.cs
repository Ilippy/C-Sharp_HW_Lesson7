// Решение в группах задач:
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int[,] array = CreateRandomArray(5, 5, 0, 10);
        PrintArray(array);
        System.Console.WriteLine();
        ChangeArray(array);
        PrintArray(array);
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

    static void ChangeArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i+=2)
            for (int j = 0; j < array.GetLength(1); j+=2)
                array[i, j] *= array[i,j];
        
    }
}