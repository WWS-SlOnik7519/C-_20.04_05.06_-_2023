// Задача 28: Напишите программу, которая
// принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <=0) Console.WriteLine("Введено не натуральное число");
else
{
    int faktorial = Faktorial(number);
    Console.WriteLine($"Факториал числа {number} равен {faktorial}");
}


int Faktorial(int num)
{
    int fakt = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            fakt = fakt * i;
        }
    }
    return fakt;
}
