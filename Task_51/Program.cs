internal partial class Program
{
    private static void Main(string[] args)
    {
        int[,] array = CreateRandomArray(5, 8, 0, 10);
        PrintArray(array);
        System.Console.WriteLine();
        Console.WriteLine($"Сумма главной диагонали {SumMainDiagonal(array)}");
    }
    static int SumMainDiagonal(int[,] arr)
    {
        int sum = 0;
        int size = Math.Min(arr.GetLength(0), arr.GetLength(1));
        for (int i = 0; i < size; i++)
            sum += arr[i, i];
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