// Формируется и выводится прямоугольный массив (n строк и m столбцов)
// целых случайных чисел от -80 до 80. 
// а) в каждой строке находится минимальный элемент и заменяется нулем; 
// б) в каждом столбце находится максимальный элемент и заменяется единицей

using NumberMain;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = CreateRandomArray(Numbers.EnterNumber("Введите количество строк в пределах[1,20]", 1, 20),
            Numbers.EnterNumber("Введите количество столбцов в пределах[1,20]", 1, 20), -80, 80);
        Console.Clear();
        PrintArray(array);
        Console.WriteLine();
        ChangeMinValueToZeroInRows(array);
        PrintArray(array);
        Console.WriteLine();
        ChangeMaxValueToOneInColumns(array);
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
                Console.Write($"{array[i, j]}\t");
            Console.WriteLine();
        }
    }

    static void ChangeMinValueToZeroInRows(int[,] array)
    {
        int minIndexValue;
        Console.Write("Минимальные значения в строчке => ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            minIndexValue = 0;
            for (int j = 1; j < array.GetLength(1); j++)
                if (array[i, j] < array[i, minIndexValue]) minIndexValue = j;
            Console.Write($"{array[i, minIndexValue]} ");
            array[i, minIndexValue] = 0;
        }
        Console.WriteLine();

    }

    static void ChangeMaxValueToOneInColumns(int[,] array)
    {
        int maxIndexValue;
        Console.Write("Максимальные значения в столбце => ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            maxIndexValue = 0;
            for (int i = 1; i < array.GetLength(0); i++){
                if (array[i, j] > array[maxIndexValue, j]) maxIndexValue = i;
                // System.Console.WriteLine($"{array[i, j]} > {array[maxIndexValue, j]}");
            }
            Console.Write($"{array[maxIndexValue, j]} ");
            array[maxIndexValue, j] = 1;
        }
        Console.WriteLine();

    }
}