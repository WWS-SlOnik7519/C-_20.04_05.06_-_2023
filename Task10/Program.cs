// Напишите программу, которая 
// на вход принимает трехзначное число 
// и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;

if (number > 99 && number < 1000)
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра -> {secondDigit}");
}
else
{
    Console.WriteLine("Некорректный ввод");
}


int SecondDigit( int num)
{
    return num / 10 % 10;
}
