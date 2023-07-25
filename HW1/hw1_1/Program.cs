Console.WriteLine("Введите первое число");
string userInputA = Console.ReadLine () ??"";
int numberA = int.Parse(userInputA);

Console.WriteLine("Введите второе число");
string userInputB = Console.ReadLine () ??"";
int numberB = int.Parse(userInputB);

if (numberA > numberB)
{
    Console.Write($"{numberA}; {numberB}; max -> {numberA}");
}
if (numberB > numberA)
{
    Console.Write($"{numberA}; {numberB}; max -> {numberB}");
}
