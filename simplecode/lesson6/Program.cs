// C# КОНВЕРТАЦИЯ СТРОКИ В ЧИСЛО | C# КЛАСС CONVERT | C# ОТ НОВИЧКА К ПРОФЕССИОНАЛУ | Урок # 6
/*string str = "3";
string str2 = "5";

int a = Convert.ToInt32(str);
int b = Convert.ToInt32(str2);

System.Console.WriteLine(a + b);*
*/
System.Console.WriteLine("Программа складыает 2 числа. Введите первое число-> ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число-> ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 + number2;

System.Console.WriteLine("Сумма двух чисел ровна: " + result);
