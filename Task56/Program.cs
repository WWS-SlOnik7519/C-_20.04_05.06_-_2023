// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("| ");
    }
}

int[] RowsSumNum(int[,] matr) // считает сумму элементов в каждой строке
{
    int[] arr = new int[matr.GetLength(0)];
    int k = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        arr[k] = sum;
        k++;
    }
    return arr;
}

int MinElemIndexes(int[] arr) // найдет элемент массива с мин.значением
{
    int min = arr[0];
    int rowIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] <= min)
        {
            min = arr[i];
            rowIndex = i;
        }
    }
    return rowIndex;
}

void PrintArrayInt(int[] arr, string sep = ",") 
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{sep} ");
        else
            Console.Write($"{arr[i]} ");
    }
}

Console.Write("Задайте количество строк/столбцов в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = rows;

int[,] array2d = CreateMatrixRndInt(rows, columns, 0, 10);
PrintMatrixInt(array2d);
Console.WriteLine();

int[] rowsSumNum = RowsSumNum(array2d);
PrintArrayInt(rowsSumNum, ",");
Console.WriteLine();

int minElemIndexes = MinElemIndexes(rowsSumNum);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minElemIndexes + 1}");
Console.WriteLine();
