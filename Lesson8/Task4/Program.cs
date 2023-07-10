/**Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
**/

int[] GetUniqueArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(minValue, maxValue);

        if (i != 0)
        {
            for (int j = 0; j < i; j++)
                while (array[j] == array[i])
                {
                    array[i] = rand.Next(minValue, maxValue + 1);
                    j = 0;
                }
        }
    }
    return array;
}

int[,,] GetUnique3DArray(int xSize = 2, int ySize = 2, int zSize = 2, int minValue = 10, int maxValue = 99)
{
    int[,,] array = new int[xSize, ySize, zSize];

    int[] baseArray = GetUniqueArray(xSize * ySize * zSize, minValue, maxValue);

    int baseIndex = 0;

    for (int i = 0; i < xSize; i++)
        for (int j = 0; j < ySize; j++)
            for (int k = 0; k < zSize; k++)
            {
                array[i, j, k] = baseArray[baseIndex];
                baseIndex++;
            }

    return array;
}

void Print3DMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество элекментов по X: ");
int arrX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элекментов по Y: ");
int arrY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элекментов по Z: ");
int arrZ = Convert.ToInt32(Console.ReadLine());
int[,,] rand3DArr = GetUnique3DArray(arrX, arrY, arrZ);
Print3DMatrix(rand3DArr);
