/**Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
**/

int sum = 0;
int numberMAX=0;
int numberMin=0;

Console.WriteLine("Введите число первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void FindSUM(int numberMAX)
{
    if (numberMAX<numberMin) return;

    sum = sum + numberMAX;
    FindSUM(numberMAX - 1);
    
}

void SerachMAx(int number3, int number4)
{
    if (number3 > number4)
    {
        numberMAX = number3;
        numberMin = number4;
    }
    else  
        numberMAX = number4;
        numberMin = number3;
}

SerachMAx(number1, number2);
FindSUM(numberMAX);
Console.Write(sum);







