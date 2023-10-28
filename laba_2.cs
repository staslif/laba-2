Console.WriteLine("Введите тариф (минут)");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Плата");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество проговоренных минут");
int B = Convert.ToInt32(Console.ReadLine());
if (A >= B)
{
    Console.WriteLine($"Плата {X}");
}
else if (A < B)
{
    Console.WriteLine("Плата за использование сверх тарифа");
    int V = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Плата {V}");
}



