Console.WriteLine("Введите число N");
double N = double.Parse (Console.ReadLine ());

int count = 2;

if (N>=2)
{
    while (count<=N)
    {
        Console.WriteLine (count);
        count = count+2;
    }
}
else
{
    if (N>0)
    {
        Console.WriteLine ("Четных чисел от 1 до N нет");
    }
    else
    {
        count = 0;
        while (count>=N)
        {
            Console.WriteLine (count);
            count = count-2;
        }
    }
}