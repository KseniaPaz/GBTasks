using static System.Console;
WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(ReadLine());
if(number > 99999 | number < 10000)
{
    WriteLine("Неверное число!");
    return;
}
int pal = 0;
int num = number;
while (number>0)
{
    pal = pal * 10 + number % 10;
    number /= 10;
}
WriteLine(num == pal? "Палиндром" : "Не палиндром");