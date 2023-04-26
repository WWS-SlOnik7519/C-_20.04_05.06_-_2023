// Напишите программу, которая 
// выводит третью цифру заданного числа
// или сообщает что третьей цифры нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;

if (number > 99)
{
    int result = ThirdDigit( number );
    Console.WriteLine($"Третья цифра -> {result}");
}
else
{
    Console.WriteLine("Третья цифра отсутствует!");
}


int ThirdDigit( int num )
{
while (num > 999)
{
    num = num / 10;
}
return num % 10;
}

