// for

string Method41(int count, string c)
{
    string result = string.Empty;
   for (int i =0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method41(100, "х");
Console.WriteLine(res);

//цикл в цикле Таблица умножения

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}