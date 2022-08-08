// на входе 2 числа
// на выход выдает какое больше, какое меньше
// a=5; b=7 max 7
Console.Write("Введите число a= ");
int a = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите число b= ");
int b = Convert.ToInt32(System.Console.ReadLine());
if (a > b) Console.WriteLine($"Число {a} больше, Число {b} меньше");
else Console.WriteLine($"Число {b} больше, Число {a} меньше");