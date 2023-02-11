Console.WriteLine("Введите первое число");
double a = double.Parse (Console.ReadLine ());

Console.WriteLine("Введите второе число");
double b = double.Parse (Console.ReadLine ());

if (a>b)
{
    Console.WriteLine("max = "+a);
    Console.WriteLine("min = "+b);
}
else 
{
if (b>a)
{
    Console.WriteLine("max = "+b);
    Console.WriteLine("min = "+a);
}
else
Console.WriteLine("числа равны");
}
