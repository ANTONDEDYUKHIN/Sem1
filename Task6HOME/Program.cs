// на входе вводится число
// программа проверяет четное или нет
Console.Write("Введите число N= ");
int N = Convert.ToInt32(System.Console.ReadLine());

if (N % 2 == 0)
{
Console.WriteLine($"число {N} четное");
}
else
{
   Console.WriteLine($"число {N} нечетное"); 
};