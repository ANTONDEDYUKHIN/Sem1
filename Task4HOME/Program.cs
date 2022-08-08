// на входе 3 числа
// на выход выдает максимальное
// a=2; b=3; c=7 max 7
Console.Write("Введите число a= ");
int a = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите число b= ");
int b = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите число b= ");
int c = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите число c= ");
if (a > b) 
{
    a = max;
}
else
{
    b = max;
}
if (b > c)
{
    b = max;
}
else
{
    c = max;
}
if (c > a)
{
    c = max;
}
else
{
    a = max;
}
Console.WriteLine($"максимальное число = {max}");