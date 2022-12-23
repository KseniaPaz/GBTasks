using static System.Console;
int number=new Random().Next(100,1000);
WriteLine(number);
number=number/10;
number=number%10;
WriteLine(number);