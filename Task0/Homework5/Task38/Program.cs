using static System.Console;

double[]array = GetArray(4, 1, 99);
PrintArray(array);
ArrayCount(array);
WriteLine();
WriteLine($"раздница между максимальным и минимальным значением: {ArrayCount(array):f1}");

double[] GetArray(int size, int start, int end)
{
    double[] resultArray = new double[size];
    Random rnd = new Random();
    for(int i=0; i<size; i++)
    {
        resultArray[i] = new Random().NextDouble()*(end-start)+start;
    }
    return resultArray;
}

void PrintArray(double[] inArray)
{
    Write("[");
    for(int i=0; i<inArray.Length-1; i++)
    {
        Write($"{inArray[i]:f1}; ");
    }
    Write($"{inArray[inArray.Length-1]:f1}]");
}


double ArrayCount(double[]inArray2)
{
double result=0;
double max=inArray2[0];
double min=inArray2[0];
for(int j=0; j<array.Length; j++)
{
    if(inArray2[j]>max) max=inArray2[j];
    if(inArray2[j]<min) min=inArray2[j];
} 
result=max-min;
return result;
}