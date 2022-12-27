using static System.Console;
Write("Введите число: ");
int.TryParse(ReadLine(), out int n);
int i = 1;
while(i <= n)
{
    WriteLine($"| {i} | {Math.Pow(i, 3)} |");
    i++;
}
