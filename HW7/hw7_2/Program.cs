// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите номер строки в массиве: ");
int rowsPos = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите номер столбца в массиве: ");
int columnsPos = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
int result = GetPositionArray(array, rowsPos, columnsPos, rows, columns);

PrintArray(array);
Console.WriteLine();
if (result == 0)
{
    Console.WriteLine();
}
else
{
    Console.WriteLine($"Значение строки {rowsPos} столбца {columnsPos} равно {result}");
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetPositionArray(int[,] array, int rowsPos, int columnsPos, int rows, int columns)
{
    int k = 0;
    if (rowsPos > rows || columnsPos > columns)
    {
        Console.WriteLine("Такого элемента массива нет");   
    }
    else
    {
        k = array[rowsPos - 1, columnsPos - 1];
    }
    return k;
}
