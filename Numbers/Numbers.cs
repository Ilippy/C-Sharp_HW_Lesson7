namespace NumberMain
{
    public static class Numbers
    {

        private static void Main(string[] args)
        {

        }
        public static double EnterDoubleNumber(string str)
        {
            System.Console.WriteLine(str);
            string stringNumber = Console.ReadLine()!.Trim();
            double number;
            while (!double.TryParse(stringNumber, out number))
            {
                Console.WriteLine($"Ошибка! {str}");
                stringNumber = Console.ReadLine()!.Trim();
            }
            return number;
        }
        public static int EnterNumber(string str)
        {
            System.Console.WriteLine(str);
            string stringNumber = Console.ReadLine()!.Trim();
            int number;
            while (!int.TryParse(stringNumber, out number))
            {
                Console.WriteLine($"Ошибка! {str}");
                stringNumber = Console.ReadLine()!.Trim();
            }
            return number;
        }

        public static int EnterNumber(string str, int min, int max)
        {
            System.Console.WriteLine(str);
            string stringNumber = Console.ReadLine()!.Trim();
            int number;
            while (!int.TryParse(stringNumber, out number) || number < min || number > max)
            {
                Console.WriteLine($"Ошибка! {str}");
                stringNumber = Console.ReadLine()!.Trim();
            }
            return number;
        }
    }
}
