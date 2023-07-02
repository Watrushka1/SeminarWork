//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] GetRandomArray()
{
    int[] Arr = new int[10];

    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = Random.Shared.Next(1, 9);
    }

    return Arr;
}

int SearchMAX(int[] Arr2)
{
   int MAX = Arr2[0];

    for (int i = 1; i < Arr2.Length; i++)
    {
        if (Arr2[i] > MAX)
        {
            MAX = Arr2[i];
        }
    }
    return MAX;
}

int SearchMIN(int[] Arr2)
{
    int MIN = Arr2[0];
 
    for (int i = 1; i < Arr2.Length; i++)
    {
        if (Arr2[i] < MIN)
        {
            MIN = Arr2[i];
        }
    }
    return MIN;
}

int[] NewArr = GetRandomArray();
int Maxnumber = SearchMAX(NewArr);
int MINnumber = SearchMIN(NewArr);
int result1 = Maxnumber-MINnumber;

Console.WriteLine($"[{string.Join(", ", NewArr)}]");
Console.WriteLine($"Максимальное число = {Maxnumber}");
Console.WriteLine($"Миниммальное число = {MINnumber}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {result1}");
