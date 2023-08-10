//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 23. Таблица кубов чисел от 1 до N";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Напишите программу, которая принимает на вход число (N) 
    и выдаёт таблицу кубов чисел от 1 до N.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной x
int n = GetNumberFromUser("Введите целое число: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
int result;
try
{
    // Вызов метода, возвращающего номер четверти по переданным координатам x и y.
    // Результат вызова присваивается переменной quarter.
    result = CounterCube(n);
}
catch (Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
//Console.WriteLine($"Таблица кубов от 1 до {n}: {result}");
#endregion --- 03. Output operations ---
// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
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
//Задача решается, но с костылями, как сделать с выводом в output operations не понимаю,
//получаю одно значение куба числа
int CounterCube(int n)
{
    int k = 1;
    int i = 1;
    Console.WriteLine($"Таблица кубов от 1 до {n}: ");
    while (i <= n)
    {
        k = Convert.ToInt32(Math.Pow(i, 3));
        i++;
        Console.Write($"{k}, ");
    }
    return k;
}
// ---------------------- Конец определения методов ----------------------------