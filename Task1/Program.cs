// на входе вводятся 2 числа
// проверяем является ли 1 квадратом 2 и наоборот
// a=25 b=5 yes,a=2 b=10 no/
Console.WriteLine("Enter int numb1= ");
int a = Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Enter int numb2= ");
int b = Convert.ToInt32(System.Console.ReadLine());
if (b*b == a) Console.WriteLine($"Number {a} is square number {b} ");
else Console.WriteLine($"Number {a} is not square number {b} ");