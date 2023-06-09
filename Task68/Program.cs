﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите положительное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int akk = Akk(numberM, numberN);
Console.WriteLine($"Значение функции Аккермана равно: {akk}");

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return Akk(m - 1, Akk(m, n - 1));
    }
}

