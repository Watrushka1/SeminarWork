/**Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
**/

const int ROWS = 5;
const int COLUMNS = 4;
int min = 0;
    int counter=1; 


int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FindMinRow(int[,] matrix)
{
    int min1 = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) //строки
    {

        for (int j = 0; j < matrix.GetLength(1); j++) //столлбцы
        {
            min1 = min1 + matrix[i, j];   
        }

      
         if (min == 0)
            {
                min = min1;
            }

        if (min1<=min)
        {
            counter=i+1;
            min=min1;  
        }
        min1=0;
    }
}

int[,] Matrix = GetRandomMatrix(ROWS, COLUMNS);
Console.WriteLine();
Console.WriteLine();
PrintMatrix(Matrix);
FindMinRow(Matrix);
Console.WriteLine($" Строка с наименьшей суммой элементов : {counter}");
Console.WriteLine($" Сумма элементов в строке : {min}");



