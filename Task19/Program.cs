// 19: Напишите программу, которая
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberModulus = Math.Abs(number);

if (numberModulus > 9999 && numberModulus < 100000)
{
    bool result = Palindrome (numberModulus);
    Console.WriteLine(result ? "Да" : "Нет");
}
else
{
    Console.WriteLine("Некорректный ввод");
}


bool Palindrome ( int num)
{
    int num1 = num / 10000;
    int num2 = num % 10;
    int num3 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    return num1 == num2 && num3 == num4;
}