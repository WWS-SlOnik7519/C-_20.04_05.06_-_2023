// Напишите программу, которая выводит случайное число
// из отрезка [10, 99]
// и показывает наибольшую цифру числа

int number = new Random().Next(10, 100); // (10, 99+1)
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if(firstDigit > secondDigit)
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");
// }

    // Тернарный оператор
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int result = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {result}");


int MaxDigit(int num)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit; 
}