/**Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
**/

const int ROWS = 5;
const int COLUMNS = 4;
int min = 0;


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
 

    for (int i = 0; i < matrix.GetLength(0); i++)
    {


        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            min1 = min1 + matrix[i, j];   
        }

         if (min == 0)
            {
                min = min1;
            }

        if (min1<=min)
        {
            min=min1;  
        }
        min1=0;
    }
}

int[,] Matrix = GetRandomMatrix(ROWS, COLUMNS);
Console.WriteLine();
Console.WriteLine("Оригинальная матрица");
Console.WriteLine();
PrintMatrix(Matrix);
FindMinRow(Matrix);
Console.WriteLine(min);



