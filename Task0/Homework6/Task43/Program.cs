using static System.Console;
var k1=AskUserForNumber("Введите k1:");
var b1=AskUserForNumber("Введите b1:");
var k2=AskUserForNumber("Введите k2:");
var b2=AskUserForNumber("Введите b2:");

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);

WriteLine($"Точка пересечения двух прямых: ({x};{y})");


double AskUserForNumber(string inPrompt)
{
    double resultNum=0;
    string userInput=" ";

    while(!double.TryParse(userInput, out resultNum))
    {
        Console.Write(inPrompt);
        userInput=Console.ReadLine()!;
    }
    return resultNum;
}