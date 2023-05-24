// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
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

void PrintArrayDouble(double[] array, string sep)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}{sep} ");
        else Console.Write($"{array[i]}");
    }
}

double MaxElement(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];  
    }
    return max;
}

double MinElement(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i]; 
    }
    return min;    
}

double[] newArray = CreateArrayRndDouble(5, 0, 100);

double maxElem = MaxElement(newArray);
double minElem = MinElement(newArray);

double Difference(double max, double min)
{
    double diff = max - min;
    double res = Math.Round(diff, 1);
    return res;
}

// Console.WriteLine($"{maxElem}");
// Console.WriteLine($"{minElem}");

double difference = Difference(maxElem, minElem);

Console.Write("[");
PrintArrayDouble(newArray, ";");
Console.Write("] -> ");
Console.Write($"{difference}");