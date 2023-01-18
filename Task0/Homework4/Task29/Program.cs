using static System.Console;
int[] arr = new int [8];
GetArray(arr);
PrintArray(arr);


int[] GetArray (int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    return array;
}

void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}, ");
    }
}