// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (number == 0 || number == 1)
{
    Console.Write("Нет четных чисел в этом диапазоне!");
}
else if (number > 1)
while (count <= number)
{
    Console.Write($"{count}, ");
    count = count + 2;
}
else
{
    Console.Write("Некорректный ввод!");
}
