/*
// 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();

// InputOp
int[] array = GetArray(12, -9, 9);
Console.WriteLine($"Random massive : [{string.Join("|", array)}]"); //метод Join выводит массив одной строкой

// Logic
int positiveSum = GetPositiveSum(array);
int negativeSum = GetNegativeSum(array);

// OutputOp
Console.WriteLine($"Positive sum = {positiveSum}, Negative sum = {negativeSum} ");

// IdentMethods
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size]; // создает в памяти новый массив, через присваивание позволяет работать с массивом в дальнейшем

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); //генерация рандомного массива (+1 верхняя граница)
    }
    return res;
}

int GetPositiveSum(int[] arr)
{
    int positiveSum = 0;
    foreach (int el in arr)
    {
        if (el > 0) positiveSum += el;
    }
    return positiveSum;
}

int GetNegativeSum(int[] arr)
{
    int negativeSum = 0;
    foreach (int el in arr)
    {
        negativeSum += el < 0 ? el : 0; //решение с помощью тернарного оператора
    }
    return negativeSum;
}
*/

/*
// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine($"Random array : [{string.Join("|", array)}]");

int[] reversArray = ReversArray1(array);
Console.WriteLine($"Reverse array 1 : [{string.Join("|", array)}]");

ReverseArray2(array);
Console.WriteLine($"Reverse array 2 : [{string.Join("|", array)}]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] ReversArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}

void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}
*/

/*
// Задача 40: Напишите программу, 
// которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

int[] array = new int[3];
Console.WriteLine("Введите длину первой стороны", "ОШИБКА!");
int[] array[0] = GetNumberFromUser();
Console.WriteLine("Введите длину первой стороны", "ОШИБКА!");
int[] array[1] = GetNumberFromUser();
Console.WriteLine("Введите длину первой стороны", "ОШИБКА!");
int[] array[2] = GetNumberFromUser();



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
*/

// Задача 46: Задайте двумерный массив размером m × n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

/*
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

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
*/

