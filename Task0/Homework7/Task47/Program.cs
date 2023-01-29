using static System.Console;
WriteLine("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[,] array=GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
WriteLine();
PrintMatrixArray(array);

double[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd=new Random();
    double[,] resultArray=new double[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            resultArray[i,j]=new Random().NextDouble()*(maxValue+1-minValue)+minValue;
        }
    }
    return resultArray;
}


void PrintMatrixArray(double[,] inArray)
{
    for (int i=0; i<inArray.GetLength(0); i++)
    {
        for (int j=0; j<inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]:f1}  ");
        }
        WriteLine();
    }
}