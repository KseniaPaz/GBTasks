using static System.Console;

Write("Введите размер массива, минимальное и максимальное значение через пробел: ");
String[] parameters=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[]array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
ArrayCount(array);
WriteLine();
WriteLine($"сумма элементов, стоящих на нечетных позициях: {ArrayCount(array)}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for(int i=0; i<size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue+1);
    }
    return resultArray;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for(int i=0; i<inArray.Length-1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}]");
}

int ArrayCount(int[]inArray2)
{
int result=0;
for(int j=0; j<array.Length; j++)
{
    if(j%2==0) result=result+array[j];
} 
return result;
}