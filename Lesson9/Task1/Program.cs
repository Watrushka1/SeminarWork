/**Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
**/

int number = 0;

Console.WriteLine("Введите число : ");
number = Convert.ToInt32(Console.ReadLine());

void FindNatural(int number1)
{
    Console.Write(number1);
    if (number1 <= 1) return;
    FindNatural(number1 - 1);
}

FindNatural(number);




