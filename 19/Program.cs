Console.Clear();
Console.WriteLine($"Введите пятизначное число:");
int num = int.Parse(Console.ReadLine());
int n1 = num%10; // последняя цифра числа
int n2 = (num/10)%10; // вторая цифра числа
int n4 = (num/1000)%10; //четвертая цифра числа
int n5 = (num/10000)%10; //пятая цифра числа
if (n1 == n5 && n2 == n4)
{
  Console.WriteLine($"Да");  
}
else
{
    Console.WriteLine($"Нет");  
}
