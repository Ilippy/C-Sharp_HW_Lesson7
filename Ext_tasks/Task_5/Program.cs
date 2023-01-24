// Формируется и выводится прямоугольный массив (6 строк и 8 столбцов)
// целых случайных чисел от -70 до 70. Вычисляется и выводится:
// а) максимальный элемент в каждой строке; 
// б) минимальный положительный элемент в каждой строке.

internal partial class Program
{
    private static void Main(string[] args)
    {
        int[,] array = CreateRandomArray(6, 8, -70, 70);
        PrintArray(array);
        Console.WriteLine();

        int[] maxValuesInRows = GetMaxValuesInRows(array);
        Console.WriteLine($"Максимальный элемент в каждой строке => [{String.Join("; ", maxValuesInRows)}]");

        int[] minPositiveValuesInRows = GetMinPositiveValuesInRows(array);
        Console.WriteLine($"Минимальный положительный элемент в каждой строке => {String.Join(";", minPositiveValuesInRows)}]");


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

    static int[] GetMaxValuesInRows(int[,] array)
    {
        int[] maxValuesInRows = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
            maxValuesInRows[i] = Enumerable.Range(0, array.GetLength(1)).Max(max => array[i, max]);
        return maxValuesInRows;
    }

    static int[] GetMinPositiveValuesInRows(int[,] array)
    {
        int[] minPositiveValuesInRows = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            minPositiveValuesInRows[i] = array[i, 0];
            for (int j = 1; j < array.GetLength(1); j++)
                if (array[i, j] < minPositiveValuesInRows[i] && array[i, j] > 0 || minPositiveValuesInRows[i] <= 0 && array[i, j] > 0)
                    minPositiveValuesInRows[i] = array[i, j];
            if (minPositiveValuesInRows[i] <= 0)
                minPositiveValuesInRows[i] = Enumerable.Range(0, array.GetLength(1)).Max(max => array[i, max]);
        }
        return minPositiveValuesInRows;
    }
}