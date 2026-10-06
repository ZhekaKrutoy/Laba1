namespace Laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма: {number1 + number2}");
            Console.WriteLine($"Разность: {number1 - number2}");
            Console.WriteLine($"Произведение: {number1 * number2}");
            Console.WriteLine($"Среднее арифметическое: {(number1 + number2) / 2.0}");
        }
    }
}
