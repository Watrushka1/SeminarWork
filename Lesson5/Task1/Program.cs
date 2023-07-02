//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetRandomArray()
{
    int[] Arr = new int[10];

    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = Random.Shared.Next(1, 9);
    }

    return Arr;
}

int PositiveNumbers(int[] Arr2)
{
    int PositiveCount = 0;
    for (int i = 0; i < Arr2.Length; i++)
    {
        if (Arr2[i] % 2 == 0)
        {
            PositiveCount++;
        }
    }
    return PositiveCount;
}

int[] NewArr = GetRandomArray();
int PositiveNumbers1 = PositiveNumbers(NewArr);

Console.WriteLine($"[{string.Join(", ", NewArr)}]");
Console.WriteLine($"Колиество чётных чисел в массиве = {PositiveNumbers1}");