//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetRandomArray()
{
    int[] Arr = new int[10];

    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = Random.Shared.Next(1, 9);
    }

    return Arr;
}

int NumbersSum(int[] Arr2)
{
    int SumNumbers = 0;
    for (int i = 0; i < Arr2.Length; i++)
    {
        if (i%2>0)
        {
           SumNumbers=SumNumbers+Arr2[i];
        }
    }
    return SumNumbers;
}

int[] NewArr = GetRandomArray();
int SumNumbers1 = NumbersSum(NewArr);

Console.WriteLine($"[{string.Join(", ", NewArr)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SumNumbers1}");
