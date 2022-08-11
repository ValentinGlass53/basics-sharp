// напишите программу, проверяющую число, введенное с клавиатуры на четность

System.Console.WriteLine("Для проверки на четность введите число ");

int number = int.Parse(Console.ReadLine());
System.Console.WriteLine(number % 2);

if ((number % 2) == 0)
{
    System.Console.WriteLine("число четное");
}
else
{
    System.Console.WriteLine("Число не четное ");
}
