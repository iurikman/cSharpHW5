/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел 
в массиве.
[345, 897, 568, 234] -> 2

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

int GetCountOfEvenNumbers(int[] array)
{
    int countOfEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) countOfEvenNumbers += 1; 
    }
    return countOfEvenNumbers;
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
    while (isCorrect == false) 
    {
        if (int.TryParse(Console.ReadLine(), out result)) isCorrect = true;
        else Console.WriteLine("Ввели не число");
    }
    return result;
}

int minValue = GetNumber("Введите минимальное значение массива:");
int maxValue = GetNumber("Введмте максимальное значение массива:");
int length = GetNumber("Введите длину массива:");

int[] array = GetArray(minValue, maxValue, length);
PrintArray(array);

int countOfPositiveNumbers = GetCountOfEvenNumbers(array);
Console.WriteLine("");
Console.WriteLine($"Количество четных значений элементов в массиве: {countOfPositiveNumbers}.");

