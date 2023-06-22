Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int NumberStart = 0;
int NumberEnd = 0;

if (number <= 99999 && number>0)
{
    NumberStart = number / 1000;
    NumberEnd = ((number % 10) * 10) + (number / 10) % 10;
    if (NumberStart == NumberEnd)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
        Console.WriteLine("Число не является палиндромом");
}
else
    Console.WriteLine("Введите положительное пятизначное число");

