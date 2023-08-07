/* Задача 19: 
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.*/

#region --- 00. Configuration. ---
Console.Clear();
Console.Title = "Задача 19. Принятие на вход пятизначного числа и его проверка на палиндромомность.";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
    Напишите программу, которая принимает на вход пятизначное число 
            и проверяет, является ли оно палиндромом.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion --- 00. Configuration. ---

#region --- 01. Input operations. ---
// Вызов метода, запрашивающего у пользователя пятизначное целое число. 
// Введённое число присваивается переменной num.
int num = GetNumberFromUser("Введите целое, пятизначное число: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations. ---

#region --- 02. Business logic. ---

string result;
try
{
    result = CheckNumberRank(num);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
if (ValidateNumber(result));
#endregion --- 02. Business logic. ---

#region --- 03. Output operations. ---
Console.WriteLine($"Число {num}: {result}");
#endregion --- 03. Output operations. ---

#region --- 04. Identify methods. ---

static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        try
        {
            Console.Write(message);
            return Int32.Parse(Console.ReadLine() ?? "");
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");
        }
    }
}

bool ValidateNumber(int num)
{
    if (num < 10000 && num > 99999)
    {
        Console.WriteLine("Ошибка! Читайте условие внимательнее");
        return false;
    }
    return true;
}

string CheckNumberRank(int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num % 100 / 10;
    int num5 = num % 10;

    if (num1 == num5 && num2 == num4)
    {
        return "Палиндром";
    }

    else
    {
        return "Не палиндром";
    }
}
#endregion --- 04. Identify methods. ---