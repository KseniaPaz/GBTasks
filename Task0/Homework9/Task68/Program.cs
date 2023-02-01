using static System.Console;

Write("Введите первое неотрицательное число m: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Write("Введите второе неотрицательное число n: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Ackerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return Ackerman (m - 1, 1);
return Ackerman (m - 1, Ackerman (m, n - 1));
}
int result = Ackerman(num1, num2);
WriteLine($"A(m,n) = {result}");