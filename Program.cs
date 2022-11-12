// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void ShowArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write("\b]");
}

int NumberOfEvenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) sum += array[i];
    }
    return sum;
}

int size = 5;
int[] newArray = CreateArray(size);
ShowArray(newArray);
Console.WriteLine($" Сумма четных чисел равна {NumberOfEvenNumbers(newArray)}");


// Задача 36: Задайте массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}
void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write("\b]");
}

int SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

int size = 7;
int[] newArray = CreateArray(size);
ShowArray(newArray);
Console.WriteLine($" Сумма чисел с нечетным индексом равна {SumOddIndex(newArray)}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.0 7.2 22.7 2.1 78.3] -> 76.2

double DiffMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] <= min) min = array[i];
        else if(array[i] >= max) max = array[i];
    }
    double difference = max - min;
    return difference;
}

Double[] array = {7.0, 8.4, 19.2, 11.7, 1.8};
Console.WriteLine($"Разница равна {DiffMaxMin(array)}");