Console.Write("[");
PrintArray(newArr);
Console.Write("]");
Console.Write($" текст: {значение/метод}");


int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);


int[,] CreateMatrixInt(int rows, int columns) // заполнение двумерного массива целыми числами по формуле
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j ;
        }
    }
    return matrix;
}


double[,] CreateMatrixRndDouble(int rows, int columns, double min, double max)//рандомное заполнение двумерного массива вещественными числами
{ 
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, 1);
        }
    }
    return matrix;
}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) //рандомное заполнение двумерного массива целыми числами
{                     //   0      1    
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows = arr.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns = arr.GetLength(1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrixInt(int[,] matrix) // печать двумерного массива целых чисел
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


void PrintMatrixDouble(double[,] matrix) // печать двумерного массива вещесвенных чисел
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


double[] CreateArrayRndDouble(int size, int min, int max) //рандомное заполнение массива вещественными числами
{
    double[] array = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArrayDouble(double[] array, string sep) // печать массива вещественных чисел
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}{sep} ");
        else Console.Write($"{array[i]}");
    }
}


int[] CreateArrayRNDInt(int size, int min, int max)//рандомное заполнение массива целыми числами
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArrayInt(int[] arr, string sep = ",") // печать массива целых чисел
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]} ");
    }
}


void FillArrayRnd(int[] array) // рандомное заполнение массива без возврата результата
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,2);
    }
}


int[] CreateArrayUser(int size) // заполнение массива пользователем
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


int Faktorial(int num) // принимает на вход число N и выдаёт произведение чисел от 1 до N.
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

int QuantityEvenNum(int[] arr) // покажет четное число элементов в массиве
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result += 1;
    }
    return result;
}


int OddPositionsSum(int[] arr) // сумма элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}


double Difference(double max, double min) // разница между максимальным и минимальным элементов массива
{
    double diff = max - min;
    double res = Math.Round(diff, 1);
    return res;
}


void ReverseArray(int[] arr) // перевернёт одномерный массив
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i]; // 2
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}


bool RuzTriangle (int X, int Y, int Z) // проверяет, может ли существовать треугольник с сторонами такой длины (теорема о неравенстве треугольника)
{
    return x < y + z & y < x + z & z < y + x;
}


Console.WriteLine (result ? $"Да это треугольник!" : "Это не треугольник"); //тернарный оператор


string DecToBin(int num) // будет преобразовывать десятичное число в двоичное
{
    string res = string.Empty;
    while (num > 0)
    {
        res = num % 2 + res;
        num = num / 2;
    }
    return res;
}


int[] Fibonacci(int num)  // не используя рекурсию, выводит первые N чисел Фибоначчи
{
    int[] arr = new int[num];
    // arr[0] = 0;
    arr[1] = 1;

    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}


int[,] ChangeRowsWithColumns (int[,] matrix)  // заменяет строки на столбцы (версия 1)
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

void Replace(int[,] matrix)  // заменяет строки на столбцы (версия 2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;

        }
    }
}


void ReplaceMatrixElement (int[,] matrix)  // поменяет местами первую и последнюю строку массива
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

            int temp = matrix[0,j];
            matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
            matrix[matrix.GetLength(0)-1,j] = temp;

        }
    }

    void Dictionary (int[] arr)  // покажет, сколько раз встречается элемент входных данных
{
    int currentValue = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == currentValue ) count ++; 
        else 
        {
            Console.WriteLine($"{currentValue} встречается {count} раз");
            count = 1;
            currentValue = arr[i];
        }

    }
    Console.WriteLine($"{currentValue} встречается {count} раз");

}

int[] MatrixToArray (int[,] matrix) // переведет двумерную марицу в одномерную
{

    int[] arr = new int [matrix.Length];
    int k = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { 
            arr[k] = matrix[i,j];
            k++;
        }
    }
    return arr;


int[] MinElemIndexes(int[,] matr) // найдет элемент массива с мин.значением
{
    int min = matr[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] <= min)
            {
                min = matr[i, j];
                row = i;
                column = j;
            }
        }
    }
    return new int[] { row, column, min };
}


int[,] DeleteRowCol(int[,] matr, int delRow, int delCol)  // удалит строку и столбец, на пересечении которых расположен наименьший элемент массива
{
    int[,] newMatrix = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == delRow) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == delCol) n++;
            newMatrix[i, j] = matr[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}

double[] ArithmeticAverage(int[,] matr)  // Найдет среднее арифметическое элементов в каждом столбце.
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


void DescendingSort(int[,] matrix)  // упорядочит по убыванию элементы каждой строки двумерного массива
{
    int temp = 0;
    int columns = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (columns = j + 1; columns < matrix.GetLength(1); columns++)
                if (matrix[i, columns] > matrix[i, j])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, columns];
                    matrix[i, columns] = temp;
                }
        }
    }
    PrintMatrixInt(matrix);
}