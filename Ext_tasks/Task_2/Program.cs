// Формируется и выводится прямоугольный массив (5 строк и 6 столбцов)
// целых случайных чисел от -40 до 40. Вычисляется и выводится: а) сумма
// чисел в каждой строке; б) среднее арифметическое чисел в каждой строке;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int[,] array = CreateRandomArray(5, 6, -40, 40);
        PrintArray(array);
        System.Console.WriteLine();
        int[] sumNumbersInRow = GetSumNumbersInRow(array);
        System.Console.WriteLine($"Сумма чисел в каждой строке -> [{String.Join("; ", sumNumbersInRow)}]");
        double[] averageNumbersInRow = GetAverageNumbersInRow(sumNumbersInRow, array.GetLength(1));
        System.Console.WriteLine($"Средне арефметическое чисел в каждой строке -> [{String.Join("; ", averageNumbersInRow)}]");

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

    static int[] GetSumNumbersInRow(int[,] array)
    {
        int[] sumNumbersInRow = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                sumNumbersInRow[i] += array[i, j];
        return sumNumbersInRow;
    }

    static double[] GetAverageNumbersInRow(int[] array, double number)
    {
        double[] averageNumbersInRow = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
            averageNumbersInRow[i] = Math.Round(array[i] / number,2);
        return averageNumbersInRow;
    
    }
}