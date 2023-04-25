// Напишите программу, которая
// выводит случайное трехзначное число и 
// удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000); // (100, 999+1)
Console.WriteLine($"Случайное трехзначное число -> {number}");

int result = DeleteSecondDigit(number);
Console.WriteLine($"Искомое число -> {result}");

int DeleteSecondDigit( int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int NeetDigit = firstDigit * 10 + thirdDigit;
    return NeetDigit;
}
