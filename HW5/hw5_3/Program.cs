// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();

double[] array = GetArray(4);
Console.WriteLine($"Random double massive : [{string.Join("|", array)}]");

double maxNumber = findMaxNumber(array);
double minNumber = findMinNumber(array);
double differenceMaxMin = maxNumber - minNumber;

Console.WriteLine($"Difference {maxNumber} - {minNumber} = {Math.Round((differenceMaxMin), 2)}");

double[] GetArray(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    { // функция Math.Round((генерация нового вещественного массива), 2 знака)
        res[i] = Math.Round((new Random().NextDouble() * 10), 2);
    }
    return res;
}

double findMaxNumber(double[] arr)
{
    double maxNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (i > maxNum) maxNum = array[i];
    }
    return maxNum;
}

double findMinNumber(double[] arr)
{
    double minNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (i < minNum) minNum = array[i];
    }
    return minNum;
}