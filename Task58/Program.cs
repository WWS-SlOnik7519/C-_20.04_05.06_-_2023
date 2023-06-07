// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


int[,] MatrixProduct(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrA.GetLength(1)];
    for (int i = 0; i < matrC.GetLength(0); i++)
    {
        for (int j = 0; j < matrC.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                sum += matrA[i, k] * matrB[k, j];
            }
            matrC[i, j] = sum;
        }

    }
    return matrC;
}


Console.Write("Задайте количество строк/столбцов в матрицах А и В: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = rows;
Console.WriteLine("");

Console.WriteLine("Матрица А");
int[,] matrixA = CreateMatrixRndInt(rows, columns, 0, 10);
PrintMatrixInt(matrixA);
Console.WriteLine("");
Console.WriteLine("Матрица В");
int[,] matrixB = CreateMatrixRndInt(rows, columns, 0, 10);
PrintMatrixInt(matrixB);
Console.WriteLine("");

Console.WriteLine("Произведение матриц А и В: Матрица C");
int[,] matrixC = MatrixProduct(matrixA, matrixB);
PrintMatrixInt(matrixC);
Console.WriteLine("");
