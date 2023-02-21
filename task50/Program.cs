Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray(m, n, 0, 9);
PrintArray(array);
Console.WriteLine("Введите позицию элемента через пробел:");
string temp = Console.ReadLine();
int[] numers = GetArrayFromString(temp);

if ((numers[0] -1 > m) || (numers[1] -1 > n))
{
    Console.WriteLine($"Такого числа в массиве нет");
}
else
{
    Console.WriteLine($"Элемент с заданной позицией : {array[numers[0]-1, numers[1]-1]}");
}



int[] GetArrayFromString(string text)
{
    string[] nums = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
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