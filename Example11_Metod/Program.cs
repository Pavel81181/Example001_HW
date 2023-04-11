// Вид1
void Method1()
{
    Console.WriteLine("Avtor...");
}
//Method1();


//2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("TEXT");


// именованный аргумент при вызове метода
void Method21(string msg)
{
    Console.WriteLine(msg);
}
//Method21(msg: "TEXT");


void Method22(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method22("TEXT",  4);
Method22(msg: "TEXT", count: 4); // имеованный аргумент
Method22(count: 3, msg: "NEW TEXT"); // можно не по порядку

// ВИД 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//ВИД 4

string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "qwer");
Console.WriteLine(res);


