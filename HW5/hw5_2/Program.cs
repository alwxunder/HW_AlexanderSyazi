﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetArray(4, -100, 100);
Console.WriteLine($"Random massive : [{string.Join("|", array)}]");

int oddNumbersSum = GetOddNumbersSum(array);

Console.WriteLine($"Odd numbers sum = {oddNumbersSum}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetOddNumbersSum(int[] arr)
{
    int oddNumSum = 0;
    foreach (int el in arr)
    {
        if (el % 2 != 0) oddNumSum += el ;
    }
    return oddNumSum;
}