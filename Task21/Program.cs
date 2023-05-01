// 21: Напишите программу, 
// которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance (x1, y1, z1, x2, y2, z2);
Console.WriteLine (Math.Round (distance, 2, MidpointRounding.ToZero));

double Distance (int numX1, int numY1, int numZ1, int numX2, int numY2, int numZ2)
{
    int numX = numX2 - numX1;
    int numY = numY2 - numY1;
    int numZ = numZ2 - numZ1;
    double result = Math.Sqrt( numX * numX + numY * numY + numZ * numZ );
    return result;
}