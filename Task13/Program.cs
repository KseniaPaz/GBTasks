using static System.Console;
WriteLine("Введите число: ");
int number = Convert.ToInt32(ReadLine());
if(number<100)
{
    WriteLine("Третьей цифры нет!");
}
else
{
    while(number>999)
    {
        number=number/10;
    }
    WriteLine(number%10);
}