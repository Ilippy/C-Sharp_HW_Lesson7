// Формируется и выводится прямоугольный массив (n строк и m столбцов)
// целых случайных чисел от -90 до 90. Вычисляется и выводится:
// а) минимальный из всех отрицательных элементов; 
// б) максимальный из модулей всех элементов массива.


using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int[,] array = CreateRandomArray(Numbers.EnterNumber("Введите количество строк в пределах[1,20]", 1, 20),
            Numbers.EnterNumber("Введите количество столбцов в пределах[1,20]", 1, 20), -90, 90);
        PrintArray(array);
        Console.WriteLine();
        Console.WriteLine($"Минимальный из всех отрицательных элементов => {GetMinValueFromArray(array)}");
        Console.WriteLine($"Максимальный из модулей всех элементов массива => {GetMaxValueFromArray(array)}");
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

    static int GetMinValueFromArray(int[,] array)
    {
        int min = array[0,0];
        foreach (int number in array)
        {
            if(number < min) min = number;
        }
        return min;
    }

    static int GetMaxValueFromArray(int[,] array)
    {
        int max = 0;
        foreach (int number in array)
        {
            if(Math.Abs(number) > Math.Abs(max)) max = number;
        }
        return max;
    }
}