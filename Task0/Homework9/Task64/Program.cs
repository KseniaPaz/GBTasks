using static System.Console;

Write("Введите число N: ");
int number = Convert.ToInt32(ReadLine());
WriteLine(GetNumbers(number));


string GetNumbers(int num)
{
    if (num == 1) return num.ToString();
    else return $"{num},{GetNumbers(num - 1)}";
}
