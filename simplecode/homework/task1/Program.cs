// Задача 1. Напишите программу, вычисляющую среднее арифметическое дух чисел

System.Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

double result = ((double)number1 + number2) / 2;
System.Console.WriteLine("Среднее арифметическое двух чисел -> " + result);