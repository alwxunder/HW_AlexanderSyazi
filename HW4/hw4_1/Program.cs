// Задача 1: Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Prompt(string message)
{
    System.Console.Write(message); // Выводим приглашение ко вводу
    string readInput = System.Console.ReadLine(); // Вводим значение 
    int result = int.Parse(readInput); // приводим к числу
    return result; // возвращаем результат
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель: ");
if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число{powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}