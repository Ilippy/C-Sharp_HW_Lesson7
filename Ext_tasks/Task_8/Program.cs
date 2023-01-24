// Формируется массив и выводится треугольная таблица, заполненная:
// а) единицами; б) нулями.
// 1
// 1 1
// 1 1 1
// 0 0 0
// 0 0
// 0

using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        int size = Numbers.EnterNumber("Введите длину массива");
        string[,] triangle1 = CreateTriangleArrayofOne(size);
        string[,] triangle2 = CreateTriangleArrayofZero(size);

        Console.Clear();
        PrintArray(triangle1);
        PrintArray(triangle2);
    }

    static void PrintArray(string[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j]} ");
            Console.WriteLine();
        }
    }

    static string[,] CreateTriangleArrayofOne(int size)
    {
        string[,] stringArray = new string[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                stringArray[i, j] = "1";
            }
        }
        return stringArray;
    }

    static string[,] CreateTriangleArrayofZero(int size)
    {
        string[,] stringArray = new string[size, size];
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - i; j++)
            {
                stringArray[i, j] = "0";
            }
        }
        return stringArray;
    }
}