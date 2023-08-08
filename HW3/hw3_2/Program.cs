//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 21. Определение расстояния между двумя точками в 3D пространстве";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Напишите программу, которая принимает на вход координаты двух точек
        и находит расстояние между ними в 3D пространстве.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число.
int xa = GetNumberFromUser("Введите целое число: ", "Ошибка ввода данных!");
int ya = GetNumberFromUser("Введите целое число: ", "Ошибка ввода данных!");
int za = GetNumberFromUser("Введите целое число: ", "Ошибка ввода данных!");
int xb = GetNumberFromUser("Введите целое число: ", "Ошибка ввода данных!");
int yb = GetNumberFromUser("Введите целое число: ", "Ошибка ввода данных!");
int zb = GetNumberFromUser("Введите целое число: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
double result;
try
{
    result = Math.Round(DistanceCalc(xa, ya, za, xb, yb, zb), 2);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"Расстояние между двумя точками в пространстве: {result}");
#endregion --- 03. Output operations ---
// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser(string message, string errorMessage)
{   
    while(true)
    {
        try
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine() ?? "");            
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");        
        }
    }
}

// Определяем функцию, принимающую 6 аргументов 
//(координаты двух точек в трехмерном пространстве)
// и возвращающую длину отрезка (расстояния между ними)

double DistanceCalc(double xa, double ya, double za, 
                    double xb, double yb, double zb)
{
  return Math.Sqrt(Math.Pow((xa-xb), 2) + Math.Pow((ya-yb), 2) + Math.Pow((za-zb), 2));
}
// ---------------------- Конец определения методов ----------------------------