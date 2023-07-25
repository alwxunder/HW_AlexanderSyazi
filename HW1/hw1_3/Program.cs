Console.WriteLine("Введите число");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput); //Сокращенное преобразование в число;

if (number % 2 == 0)
{
    Console.WriteLine($"{number} -> Делится");
}
else
{
    Console.WriteLine($"{number} Не делится");
}