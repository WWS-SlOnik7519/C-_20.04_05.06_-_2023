// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите Координаты точек ");

Console.WriteLine("x = ");
int x = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("y = ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Z = ");
int z = Convert.ToInt32(Console.ReadLine());

bool result = RuzTriangle(x,y,z);

Console.WriteLine (result ? $"Да это треугольник!" : "Это не треугольник");

bool RuzTriangle (int X, int Y, int Z)
{
    return x < y + z & y < x + z & z < y + x;
}