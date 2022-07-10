Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num1>max) max = num1;
if (num2>max) max = num2;

Console.WriteLine("max = " + max);