using static System.Console;

Write("Введите число M: ");
int M = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int N = Convert.ToInt32(ReadLine());

int SumNumbers(int minValue, int maxValue)
{
    if(minValue == maxValue) return maxValue;
    return SumNumbers(minValue + 1, maxValue) + minValue;
}
int sum = SumNumbers(M, N);
WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}  = {sum}");