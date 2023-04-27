﻿// Напишите программу, которая 
// принимает на вход два числа
// и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = IsSquare(number1, number2);
Console.WriteLine(result ? "Да" : "Нет");

bool IsSquare(int num1, int num2)
{
    return num2 == num1 * num1 || num1 == num2 * num2;
}