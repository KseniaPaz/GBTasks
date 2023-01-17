using static System.Console;
Write("Введите число А: ");
int.TryParse(ReadLine(), out int a);
Write("Введите число B: ");
int.TryParse(ReadLine(), out int b);
int Pow=GetPow(a,b);
WriteLine($"{a} в {b} степени = {Pow}");

int GetPow(int A, int B)
{
    int result = 1;
    while(B>0)
    {
        result=result*A;
        B--;
    }
    return result;
}