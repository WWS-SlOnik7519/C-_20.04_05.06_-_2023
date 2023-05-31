// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] ArithmeticAverage(int[,] matr)
{
    double[] arr = new double[matr.GetLength(1)];
    int k = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int sum = 0;
        double result = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
        }
        result = (double)sum / matr.GetLength(0);
        arr[k] = Math.Round(result, 1);
        k++;
    }
    return arr;
}

void PrintArrayDouble(double[] array, string sep)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}{sep} ");
        else
            Console.Write($"{array[i]}");
    }  
    Console.WriteLine();
}

int[,] createMatrixRndInt = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrixInt(createMatrixRndInt);
double[] arithmeticAverage = ArithmeticAverage(createMatrixRndInt);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(arithmeticAverage, ";");
Console.WriteLine();