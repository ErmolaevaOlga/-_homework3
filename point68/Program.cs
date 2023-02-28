Console.Clear();

Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"A({m},{n}) = {AkkNumbers(m, n)}");

int AkkNumbers(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ( n == 0)
        {
            return AkkNumbers(m-1, 1);
        }
    }
    int result = AkkNumbers (m-1, AkkNumbers(m, n -1));
    return result;
}