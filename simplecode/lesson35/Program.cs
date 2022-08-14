// C# ФУНКЦИИ И МЕТОДЫ | МЕТОД C# ЧТО ЭТО | ФУНКЦИИ C# ПРИМЕР | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | # 35
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int sum(int a, int b)
{
    //int result = a + b;
    //return result;
    return a + b;
}
void PrintResult(int result){
    System.Console.WriteLine("результат сложения: " + result);
}

int c = sum(a, b);
PrintResult(c);

void PrintLine()
    {
        System.Console.WriteLine("Метод райтлайн был вызван");
    }
    
    PrintLine();