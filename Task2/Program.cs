int max = 0;
int max1 = 0;
Console.WriteLine("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c : ");
int c = Convert.ToInt32(Console.ReadLine());


if (a > b)
{
    max = a;
}
else max = b;

if (max < c)
{
    max1 = c;
}
else max1 = max;
Console.WriteLine("Максимальное число: ");
Console.WriteLine(max1);
