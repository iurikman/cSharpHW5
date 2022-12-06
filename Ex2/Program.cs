/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int minValue, int maxValue, int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

int SummOfUnevenPosValues(int[] array)
{
    int summOfUnevenPosValues = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) summOfUnevenPosValues += array[i];
    }
    return summOfUnevenPosValues;
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
    }
    return result;
}

int minValue = GetNumber("Введиие минимальное значение массива:");
int maxValue = GetNumber("Введите максимальное значение массива:");
int length = GetNumber("Введите длину массива:");
int[] array = GetArray(minValue, maxValue, length);
Console.WriteLine("");
PrintArray(array);

int summOfUnevenPosValues = SummOfUnevenPosValues(array);
Console.WriteLine("");
Console.WriteLine($"Сумма нечетных позиций массива: {summOfUnevenPosValues}.");
