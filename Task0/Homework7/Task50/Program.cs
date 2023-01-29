using static System.Console;
WriteLine("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine("Введите индекс строки: ");
int A = Convert.ToInt32(ReadLine());
WriteLine("Введите индекс столбца: ");
int B = Convert.ToInt32(ReadLine());

int[,] array=GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
WriteLine();
PrintMatrixArray(array);
WriteLine(ArrayCount(array, A, B));


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd=new Random();
    int[,] resultArray=new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            resultArray[i,j]=rnd.Next(minValue, maxValue+1);
        }
    }
    return resultArray;
}


void PrintMatrixArray(int[,] inArray)
{
    for (int i=0; i<inArray.GetLength(0); i++)
    {
        for (int j=0; j<inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j],3} ");
        }
        WriteLine();
    }
}


int ArrayCount(int[,]inMatrix, int a, int b)
{
    int result=0;
    if(a>inMatrix.GetLength(0) || b>inMatrix.GetLength(1)) WriteLine("Такого элемента в массиве нет");
    else
    {
        result=inMatrix[a,b];
    } 
    return result;
}