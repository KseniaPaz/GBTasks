using static System.Console;

WriteLine("Введите размер матриц и диапозон значений через пробел: ");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] array = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[1]), int.Parse(parametrs[3]));
WriteLine("Первая матрица:");
PrintMatrixArray(array);
WriteLine("Вторая матрица:");

int[,] array2 = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[1]), int.Parse(parametrs[3]));

PrintMatrixArray(array2);
WriteLine("Результирующая матрица: ");

int[,] resultMatrixArray = MultiMatrix(array, array2);
PrintMatrixArray(resultMatrixArray);
int[,] MultiMatrix(int[,] inArray1, int[,] inArray2)
{
    
    int[,] resultMatrix = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)
        {
            for (int k = 0; k < inArray2.GetLength(0); k++)
            {
                resultMatrix[i, j] += inArray1[i, k] * inArray2[k, j];
            }
        }
    }
    return resultMatrix;
}


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}