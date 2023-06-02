// Задача 55. Задайте двумерный массив. 
// Напишите программу,  которая 
// заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] ChangeRowsWithColumns (int[,] matrix)
{
    int[,] newmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++) // rows = arr.GetLength (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns = arr.GetLength (1)
        {
            newmatrix[i, j] = matrix[j,i]; // [1;10)]
        }
    }
    return newmatrix;
}

int[,] array2d = CreateMatrixRndInt(rrows, ccolumns);
PrintMatrix(array2d);
Console.WriteLine(); //разделяем новый и старый массив пустой строкой

if (rrows != ccolumns) 
{
    Console.WriteLine ("Замена строк столбцами невозможна");
    return;
}

int [,] newarray2d = ChangeRowsWithColumns (array2d);
PrintMatrix(newarray2d);