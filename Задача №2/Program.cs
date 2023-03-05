Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
Console.Write($"Max = {b} ; Min = {a}");
else 
Console.Write($"Max = {a} ; Min = {b}");