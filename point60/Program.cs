Console.Clear();
Console.WriteLine("Введите первое измерение массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе измерение массива:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье измерение массива:");
int p = int.Parse(Console.ReadLine());


int[,,] array = GetArray(m, n, p, 10, 100);
PrintArray(array);

void PrintArray(int[,,] array)
{
     for (int i = 0; i <m; i++)
    {
        for (int j = 0; j< n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            
        }
        Console.WriteLine();
    }
}


 int[,,] GetArray(int m, int n, int p, int minValue, int maxValue)
{
    int[,,] result = new int [m, n, p];
    Random rand = new Random(((int)DateTime.Now.Ticks));
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j< n; j++)
        {
            for (int k = 0; k < p; k++)
            {
               result[i, j, k] = rand.Next(10, 100); 
            }
            
        }
    }
    return result;
}
