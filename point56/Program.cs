Console.Clear();
Console.WriteLine("Введите размерность массива:");
int m = int.Parse(Console.ReadLine());

int[,] array = GetArray(m, m, 1, 9);
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Строка с наименьшей суммой элементов: {FindMinElem(array)}");

int FindMinElem(int[,] array)
{
    int[] temp = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[i] += array[i,j];
        }     
    }
    int min = temp[0];
    int minI = 0;
    for (int i = 1; i < temp.GetLength(0); i++)
    {
        minI = temp[i] < min ? i : minI;

    }
    Console.WriteLine($"Сумма элементов построчно : {String.Join(", ", temp)}");
    return minI;
}

void PrintArray(int[,] array)
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


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m, n];
    for (int i = 0; i <m; i++)
    {
        for (int j = 0; j< n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

