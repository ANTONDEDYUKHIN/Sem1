// написать программу, которая будет
// определять по номеру день недели
// 3 - среда, 5 - пятница
Console.Write("Enter int number: ");
int a = Convert.ToInt32(System.Console.ReadLine());
if( a == 1) System.Console.WriteLine("Monday");
else if( a == 2) System.Console.WriteLine("Tuesday");
else if( a == 3) System.Console.WriteLine("Wednesday");
else if( a == 4) System.Console.WriteLine("Thursday");
else if( a == 5) System.Console.WriteLine("Friday");
else if( a == 6) System.Console.WriteLine("Saturday");
else if( a == 7) System.Console.WriteLine("Sunday");
else System.Console.WriteLine("Number is not diapasone");
