// на входе число Н
// на выходе ряд чиесл от -Н до Н
// 2 - -2,-1,0,1,2
Console.Write("Enter int number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Print numbers in diap -N:N :");
for (int i = -a; i <= a; i++);
{
    Console.Write(i + " ");
}
