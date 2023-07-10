/**Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
6 16
9 6
**/

const int ROWS = 2;
const int COLUMNS = 2;
int[,] NewMatrix = new int[2, 2];

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

int[,] Matrix1 = GetRandomMatrix(ROWS, COLUMNS);
int[,] Matrix2 = GetRandomMatrix(ROWS, COLUMNS);
Console.WriteLine();
Console.WriteLine();
PrintMatrix(Matrix1);
Console.WriteLine();
PrintMatrix(Matrix2);
Console.WriteLine();

void ResultMatrix()
{
    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix1.GetLength(1); j++)
        {
            NewMatrix[i, j] = Matrix1[i, j] * Matrix2[i, j];
        }
    }
}
ResultMatrix();
Console.WriteLine("Результирующая матрица: ");
PrintMatrix(NewMatrix);
