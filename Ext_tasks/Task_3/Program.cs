// Формируется и выводится прямоугольный массив (n строк и m столбцов)
// целых случайных чисел от -50 до 50. Вычисляется и выводится: 
// а) среднее арифметическое отрицательных чисел в каждой строке; 
// в) сумма и среднее арифметическое положительных четных чисел в каждой строке; 
// д) сумма и среднее арифметическое всех чисел.


using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int[,] array = CreateRandomArray(Numbers.EnterNumber("Введите количество строк в пределах[1,20]", 1, 20),
            Numbers.EnterNumber("Введите количество столбцов в пределах[1,20]", 1, 20), -50, 50);
        PrintArray(array);
        Console.WriteLine();

        double[] averageNegativeNumbersInRow = GetAverageNegativeNumbersInRow(array);
        Console.WriteLine($"Среднее арифметическое отрицательных чисел в каждой строке => " +
            $"[{String.Join("; ", averageNegativeNumbersInRow)}]");

        double[] averagePositiveEvenNumbersInRow = GetAveragePositiveEvenNumbersInRow(array);
        Console.WriteLine($"Среднее арифметическое положительных четных чисел в каждой строке => " +
            $"[{String.Join("; ", averagePositiveEvenNumbersInRow)}]");
        Console.WriteLine($"Сумма среднее арифметическое положительных четных чисел в каждой строке => "+
            $"{averagePositiveEvenNumbersInRow.Sum()}");
            
        Console.WriteLine($"Среднее арифметическое всех чисел => {GetAverageNumbers(array)}");
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

    static double[] GetAverageNegativeNumbersInRow(int[,] array)
    {
        double[] averageNegativeNumbersInRow = new double[array.GetLength(0)];
        double negativeNumbersCount;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            negativeNumbersCount = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < 0)
                {
                    averageNegativeNumbersInRow[i] += array[i, j];
                    negativeNumbersCount++;
                }
            }
            averageNegativeNumbersInRow[i] = Math.Round(averageNegativeNumbersInRow[i] /
                (negativeNumbersCount == 0 ? 1 : negativeNumbersCount), 2);
        }
        return averageNegativeNumbersInRow;
    }

    static double[] GetAveragePositiveEvenNumbersInRow(int[,] array)
    {
        double[] averagePositiveEvenNumbersInRow = new double[array.GetLength(0)];
        double positiveEvenCount;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            positiveEvenCount = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > 0 && array[i, j] % 2 == 0)
                {
                    averagePositiveEvenNumbersInRow[i] += array[i, j];
                    positiveEvenCount++;
                }
            }
            averagePositiveEvenNumbersInRow[i] = Math.Round(averagePositiveEvenNumbersInRow[i] /
                (positiveEvenCount == 0 ? 1 : positiveEvenCount), 2);
        }
        return averagePositiveEvenNumbersInRow;
    }

    static double GetAverageNumbers(int[,] array)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                result += array[i, j];
        System.Console.WriteLine($"Сумма всех чисел {result}");
        return Math.Round(result / array.Length, 2);
    }



}