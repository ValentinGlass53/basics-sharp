// Вид 1: Не принимает и не отдает. Все делается внутри

void Method1()
{
    System.Console.WriteLine("метод 1");
}
Method1();

//Вид2 Принемает аргументы, но не озвращает

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2("текст");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Текст2", count: 4);


// Вид3 не принемают, но возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);


// Вид4 принемают и озращают аргументы

/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;   //пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "af");
System.Console.WriteLine(res);
*/

string Method4(int count, string text)
{
    string result = String.Empty;   //пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "af");
System.Console.WriteLine(res);



for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i}x{j}={i*j}");
    }
    System.Console.WriteLine();

}