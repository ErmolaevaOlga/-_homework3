Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = int.Parse(Console.ReadLine());
double[,] array = GetArray(m, n, 0, 9);
PrintArray(array);
double[] massiv = GetAverage(array);

Console.WriteLine($"Среднее арифметическое каждого столбца : {String.Join(", ", massiv)}");

double[] GetAverage(double[,] array)
{
    double[] massiv = new double[array.GetLength(1)];
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
      
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
           
        }
        massiv[j] = Math.Round(sum / array.GetLength(0), 2);
    }
    return massiv;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double [m, n];
    for (int i = 0; i <m; i++)
    {
        for (int j = 0; j< n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
