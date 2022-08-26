// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите коэффициенты уравнений");
Console.Write("K1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("K2: ");
double k2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите свободные члены уравнений");
Console.Write("b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("b2: ");
double b2 = int.Parse(Console.ReadLine()!);
if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
    Environment.Exit(0);
}
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны и не пересекаются");
    Environment.Exit(0);
}

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine("Точка пересечения прямых - (" + x + "; " + y + ")");
