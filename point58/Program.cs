Console.Clear();
Console.WriteLine("Введите количество строк первого массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первого массива:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк второго массива:");
int m1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второго массива:");
int n1 = int.Parse(Console.ReadLine());
int[,] array1 = GetArray(m, n, 0, 9);
int[,] array2 = GetArray(m1, n1, 0, 9);

if (CheckComp(n, m1))
{
    MatrixMulty(array1, array2);
}
else
{
    Console.WriteLine("Матрицы не совместимы");
    return;
}

Console.WriteLine("Первая матрица:");
PrintArray(array1);
Console.WriteLine("Вторая матрица:");
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");

PrintArray(MatrixMulty(array1, array2));

int[,] MatrixMulty(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            result[i,j] = ScalarMulty(array1, array2, i, j);
        } 
       
    }
    return result;
}

int ScalarMulty(int[,] array1, int[,] array2, int line, int column)
{
    int result = 0;
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        result += array1[line,i]*array2[i,column];
           
    }
    
    return result;
}

bool CheckComp (int n, int m1)
{
    if (n == m1) 
    {
        return true;
    }
    return false;
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

