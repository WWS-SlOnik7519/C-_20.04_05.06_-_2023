// 1. Напишите программу, которая
// 2. на вход принимает число
// 3. и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine()); // или int number = Convert.ToInt32(Console.ReadLine());    // "7" -> 7
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
