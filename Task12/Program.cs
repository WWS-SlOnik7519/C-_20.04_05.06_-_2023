// Напишите программу, которая
// будет принимать на вход два числа и
// будет выводить, является первое число кратным второму.
// Если первое число не кратно второму, то 
// программа выводит остаток  от деления.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);
string result = remainder == 0 ? "кратно" : $"не кратно, остаток {remainder}";
Console.WriteLine(result);


int Remainder(int num1, int num2)
{
    return num1 % num2;
}
