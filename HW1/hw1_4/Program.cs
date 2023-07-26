Console.WriteLine("Введите целое число, больше нуля");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput); // ввод данных

if (number <= 0) // проверка на целое и больше нуля
{
    Console.WriteLine("Число меньше или равно нулю");
    return;
}
int i = 2; // исполнительная часть
if (i % 2 == 0)
    while (i <= number)
{
    Console.Write($"{i}, "); // вывод результата, почему получается знак процента на выводе?
    i = i + 2;
}