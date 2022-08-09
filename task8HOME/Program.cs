// на входе число Н
// на выходе ряд четных чисел от 1 до Н
// 5 - 2, 4
Console.Write("Enter int number: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("All numbers of interval 1-N: ");
for (int i = 2; i <= N; i++)
if (i % 2 == 0)
{
    Console.Write(i +", ");
}
