Console.Clear();
Console.WriteLine($"Введите число:");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n+1; i++)
{
    Console.Write($"{Math.Pow(i,3)} ");
}

