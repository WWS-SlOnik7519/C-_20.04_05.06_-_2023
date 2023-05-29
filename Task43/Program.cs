// Задача 43: Напишите программу,
// которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());


double numX = IntersectionPointX (b1, k1, b2, k2);
double numY = IntersectionPointY (b1, k1);

Console.WriteLine($"Координаты точки пересечения этих прямых: ({Math.Round(numX, 1)}; {Math.Round(numY, 1)})");

double IntersectionPointX (int num1, int num2, int num3, int num4)
{
    double x = (double)(num3 - num1) / (num2 - num4);
    return x;
}

double IntersectionPointY (int num1, int num2)
{
    double y = IntersectionPointX (b1, k1, b2, k2) * num2 + num1;
    return y;
}
