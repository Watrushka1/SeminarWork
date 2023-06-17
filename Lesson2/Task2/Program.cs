Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
 while (number>999)
 {
 number/=10;
 }
// return number%10;
Console.Write(number%10);
}
else
    Console.Write("Третьей цифры нет");