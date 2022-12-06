/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] GetArray(int minValue, int maxValue, int length)
{
    int[] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

int GetDiffMaxMin(int[] array)
{
    int minValue = array[0];
    int maxValue = array[0];
    int diffMaxMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue) maxValue = array[i];
        if (array[i] < minValue) minValue = array[i];
    }
    diffMaxMin = maxValue - minValue;
    return diffMaxMin;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int result = 0;
    bool isCorrect = false;
    while (!isCorrect)
    {
        if (int.TryParse(Console.ReadLine(), out result)) isCorrect = true;
        else Console.WriteLine("Ввели не число");
    }
    return result;
}

int minValue = GetNumber("Введите минимальное значение массива: ");
int maxValue = GetNumber("Введите максимальное значение массива: ");

if (maxValue >= minValue) 
{
int length = GetNumber("Введите длину массива: ");
Console.WriteLine("");

int[] array = GetArray(minValue, maxValue, length);
int diffMaxMin = GetDiffMaxMin(array);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"Разница между макс и мин значениями массива: {diffMaxMin}.");
}
else Console.WriteLine("Ошибка! Максимальное значение меньше минимального!");
