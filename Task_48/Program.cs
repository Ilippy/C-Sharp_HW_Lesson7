internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = CreateArray(3, 4);
        PrintArray(array);
    }

    static int[,] CreateArray(int rows, int columns)
    {
        int[,] array = new int[rows, columns];
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = i + j;
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