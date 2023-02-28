Console.Clear();


Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Натуральные числа в промежутке от {n} до 1: {PrintNumbers(n)}");

string PrintNumbers(int n)
{
    if (n == 1)
    {
        return "1";
    }
    string s = n.ToString() + " " + PrintNumbers(n - 1);
    return (s);
}
