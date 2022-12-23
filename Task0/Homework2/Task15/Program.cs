using static System.Console;
WriteLine("Введите число от 1 до 7:");
int number = Convert.ToInt32(ReadLine());
if(number>7)
{
    WriteLine("Введено неверное число");
}
if(number<6)
{
    WriteLine("нет");
}
if(number==6|number==7)
{
    WriteLine("Выходной!");
}