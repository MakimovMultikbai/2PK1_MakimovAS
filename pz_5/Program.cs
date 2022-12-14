Console.WriteLine("1 Задание");
for (int i = 10; i <= 100; i += 5)
{
    Console.WriteLine(i);
}

Console.WriteLine("2 Задание");
for (char i = 'А'; i <= 'Д'; i++)
{
    Console.Write(i);
}
Console.WriteLine();

Console.WriteLine("3 Задание");
int n = 6;
int m = 7;
for (int i = 0; i < m; i++)
{
    for (int x = 0; x < n; x++)
    {
        Console.Write('#');
    }
    Console.WriteLine();
}

Console.WriteLine("4 Задание");
int y = 0;
for (int i = 0; i < 100; i++)
{
    if (y == i % 6)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("5 Задание");

for (int i = 3, j = 50; j - i != 27; i++, j--)
{
    Console.WriteLine(i + "    " + j);
}
