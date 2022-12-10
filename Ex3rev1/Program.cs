/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] GetArray(double minValue, double maxValue, int length)
{
    double[] array = new double [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = minValue + rnd.NextDouble()*(minValue + maxValue);
    }
    return array;
}

double GetDiffMaxMin(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
    double diffMaxMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue) maxValue = array[i];
        if (array[i] < minValue) minValue = array[i];
    }
    diffMaxMin = maxValue - minValue;
    return diffMaxMin;
}

void PrdoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

double GetNumber(string text)
{
    Console.WriteLine(text);
    double result = 0;
    bool isCorrect = false;
    while (!isCorrect)
    {
        if (double.TryParse(Console.ReadLine(), out result)) isCorrect = true;
        else Console.WriteLine("Ввели не число");
    }
    return result;
}

double minValue = GetNumber("Введите минимальное значение массива: ");
double maxValue = GetNumber("Введите максимальное значение массива: ");

if (maxValue >= minValue) 
{
int length = Convert.ToInt32(GetNumber("Введите длину массива: "));
Console.WriteLine("");

double[] array = GetArray(minValue, maxValue, length);
double diffMaxMin = GetDiffMaxMin(array);
PrdoubleArray(array);
Console.WriteLine("");
Console.WriteLine($"Разница между макс и мин значениями массива: {diffMaxMin}.");
}
else Console.WriteLine("Ошибка! Максимальное значение меньше минимального!");
