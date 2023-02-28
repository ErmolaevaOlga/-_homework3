Console.Clear();

Console.WriteLine("Введите M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}: {SumNumbers(m, n)}");

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    int result = m + SumNumbers(m+1, n);
    return result;
}