// Задан прямоугольный массив названий и обозначений транспортных средств,
// (a – автомобиль, v – велосипед, m - мотоцикл, p – поезд, s – самолет).
// По введенному обозначению транспортного средства выводится его название
internal partial class Program
{
    private static void Main(string[] args)
    {
        string[,] transport = {{"a","автомобиль"},
            {"v","велосипед"},
            {"m", "мотоцикл"},
            {"p", "поезд"},
            {"s", "самолет"}};
        System.Console.WriteLine($"Введит один из символов [a, v, m, p, s]");
        char vehichelChar = Console.ReadKey().KeyChar;
        System.Console.WriteLine();
        Console.WriteLine($"{vehichelChar} -> {FindVehichel(transport, vehichelChar)}");
    }

    static string FindVehichel(string[,] array, char vehichelChar)
    {
    for (int i = 0; i < array.GetLength(0); i++)
        if(array[i,0] == vehichelChar.ToString()) return $"{array[i,1]}"; 
    return "не входит в массив";
    }
}