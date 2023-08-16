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
