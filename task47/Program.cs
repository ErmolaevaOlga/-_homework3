Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение:");
double minValue = double.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение:");
double maxValue = double.Parse(Console.ReadLine());
double[,] array = GetArray(m, n, minValue, maxValue);
PrintArray(array);

void PrintArray(double[,] array)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]: 0.00} ");
        }
        Console.WriteLine();
    }
}


double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double [m, n];
    for (int i = 0; i <m; i++)
    {
        for (int j = 0; j< n; j++)
        {
            result[i, j] = new Random().NextDouble()*((maxValue-minValue)+minValue);
        }
    }
    return result;
}

