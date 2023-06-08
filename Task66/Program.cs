// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.Write("Некорректный ввод!");
}
else
{
    int naturalNumbersSum = NaturalNumbersSum(numberM, numberN);
    Console.WriteLine($"{naturalNumbersSum}");
}

int NaturalNumbersSum(int numM, int numN)
{
    if (numM <= numN)
    {
        if (numM == numN)
            return numM;
        return numM + NaturalNumbersSum(numM + 1, numN);
    }
    else
    {
        return numM + NaturalNumbersSum(numM - 1, numN);
    }
}
