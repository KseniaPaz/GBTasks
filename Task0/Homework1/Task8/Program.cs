using static System.Console;
WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
int b = 0;
while(b < a)
{
    b++;
    if(b%2==0)
    Write($"{b},");
}