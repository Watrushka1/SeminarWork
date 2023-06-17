Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<8)
{
    if (number != 7 && number != 6)
    {
        Console.Write("Будний день");
    }
    else
    {
        Console.Write("Выходной день");
    }
}
else  Console.Write("Введеноое число некорректно");

