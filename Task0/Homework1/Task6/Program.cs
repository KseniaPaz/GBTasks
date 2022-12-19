using static System.Console;
WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
//int result = a % 2;
if(a % 2 == 0) 
{
    WriteLine($"{a} - четное число");

}    
else
WriteLine($"{a} - нечетное число");