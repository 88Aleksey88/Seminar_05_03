Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
Console.Write($"Max = {b} ; Min = {a}");
else if (a > b)
Console.Write($"Max = {a} ; Min = {b}");
else 
Console.Write("Цифры равны");