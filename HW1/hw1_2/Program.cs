Console.WriteLine("Введите первое число");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);

Console.WriteLine("Введите второе число");
string userInput2 = Console.ReadLine() ?? "";
int number2 = int.Parse(userInput2);

Console.WriteLine("Введите третье число");
string userInput3 = Console.ReadLine() ?? "";
int number3 = int.Parse(userInput3);

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
{
    Console.Write($"{number1}; {number2}; {number3}; -> {max} ");
}