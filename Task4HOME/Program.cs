// на входе 3 числа
// на выход выдает максимальное
// a=2; b=3; c=7 max 7
Console.Write("Введите число a= ");
int a = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите число b= ");
int b = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите число c= ");
int c = Convert.ToInt32(System.Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"максимальное число = {max}");