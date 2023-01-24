// Формируется и выводится прямоугольный массив - таблица умножения двух
// чисел от 1 до 10.

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = CreateArray(10,10);
        PrintArray(array);
    }

    static int[,] CreateArray(int rows, int columns)
    {
        int[,] array = new int[rows, columns];
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = (i+1) * (j+1);
        return array;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j]}\t");
            Console.WriteLine();
        }
    }
}