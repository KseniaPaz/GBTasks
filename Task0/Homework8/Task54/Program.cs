﻿using static System.Console;

WriteLine("Введите размер матрицы и диапозон целых значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] matrix = GetMatrix(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrix(matrix);
WriteLine();
SortRowsMatrix(matrix);
PrintMatrix(matrix);


void SortRowsMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < inMatrix.GetLength(1); k++)
            {
                if (inMatrix[i, j] < inMatrix[i, k])
                {
                    int temp = inMatrix[i, k];
                    inMatrix[i, k] = inMatrix[i, j];
                    inMatrix[i, j] = temp;
                }
            }
        }
    }
}
int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j],3} ");
        }
        WriteLine();
    }
}