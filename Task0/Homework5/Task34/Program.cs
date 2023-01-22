using static System.Console;

int[]array = GetArray(4, 100, 999);
PrintArray(array);
ArrayCount(array);
WriteLine();
WriteLine($"количество четных чисел в массиве: {ArrayCount(array)}");

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
int number=0;
foreach(int a in array)
{
    number=a%2;
    if(number==0) result++;
}
return result;
}