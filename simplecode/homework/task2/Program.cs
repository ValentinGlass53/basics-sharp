// задача 2. Введите три числа и выведите на экран значение суммы и произведения этих чисел.

System.Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());

int sum = num1 + num2 + num3;
int piece = num1 * num2 * num3;

System.Console.WriteLine("Сумма чисел ровна -> " + sum + ", А произвведение ->" + piece );
