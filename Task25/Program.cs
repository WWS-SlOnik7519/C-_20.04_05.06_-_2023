﻿// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите натуральное число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > 0)
{
    int power = Exponent(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {power}");
}
else
{
    Console.WriteLine("Некорректный ввод!");
}

int Exponent(int a, int b)
{
            int pow = a;
        for (int i = 2; i <= b; i++)
        {
            pow = pow * a;
        }
        return pow;
   }