using static System.Console;
WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(ReadLine());
if(number>999)
{
    WriteLine("Введено не верное число!");
}
else
{
    number=number/10;
    number=number%10;
    WriteLine(number);
}