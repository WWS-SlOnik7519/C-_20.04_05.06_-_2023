// 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance (x1, y1, x2, y2);
// double distanceRound = Math.Round (distance, 2);
Console.WriteLine (Math.Round (distance, 2, MidpointRounding.ToZero));

double Distance (int num1, int num2, int num3, int num4)
{
    double result = Math.Sqrt((num3 - num1) * (num3 - num1) + (num4 - num2) * (num4 - num2));
    return result;
}