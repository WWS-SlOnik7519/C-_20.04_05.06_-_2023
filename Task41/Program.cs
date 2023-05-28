// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

int[] newArr = CreateArrayUser(5);
int quantityGreaterZero = QuantityGreaterZero(newArr);
Console.Write("[");
PrintArray(newArr);
Console.Write("]");
Console.Write($" -> Количество чисел больше нуля: {quantityGreaterZero}");

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
}

int[] CreateArrayUser(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int QuantityGreaterZero(int[] arr)
{
    int Quantity = 0;
    for (int i = 0; i < newArr.Length; i++)
    {
        if (newArr[i] > 0)
            Quantity += 1;
    }
    return Quantity;
}
