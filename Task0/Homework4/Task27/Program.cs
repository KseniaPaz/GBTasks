using static System.Console;
Write("Введите число: ");
int.TryParse(ReadLine(), out int number);
int Sum = GetSum(number);
WriteLine($"Сумма цифр числа {number} = {Sum}");

int GetSum(int num)
{
    int result = 0;
    while(num>0)
    {
        result = result+num%10;
        num = num/10;
    }
   return result; 
}
