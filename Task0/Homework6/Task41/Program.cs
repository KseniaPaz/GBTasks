using static System.Console;
Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll(ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
ArrayCount(array);
WriteLine();
WriteLine($"количество чисел больше 0: {ArrayCount(array)}");

int ArrayCount(int[]inArray)
{
int result=0;
for(int i=0; i<inArray.Length; i++)
{
    if(inArray[i]>0) result++;
} 
return result;
}