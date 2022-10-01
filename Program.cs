﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void Zadacha34()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    FindEvenNumbers(numbers);
    Console.WriteLine();
}
void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(100, 1000);
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ",");
    }
    Console.WriteLine();
}

void FindEvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count + "- количество чётных чисел");
}
Zadacha34();

//Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

void Zadacha36()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    FindSumOddIndexNumbers(numbers);
    Console.WriteLine();
}

void FindSumOddIndexNumbers(int [] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + numbers[i];
        }
    }
    Console.WriteLine("Сумма элементов с нечётными индексами = " + sum);
}
Zadacha36();

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Zadacha38()
{
    int size = 8;
    double [] numbers = new double[size];
    FillArray1(numbers);
    PrintArray1(numbers);
    FindDiffMinAndMax(numbers);
}
void FillArray1(double[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;;
    }
}
void PrintArray1(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}
void FindDiffMinAndMax(double[] numbers)
{
    double min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
Console.WriteLine($"Минимальный элемент = {min} Максимальный элемент = {max}");
Console.WriteLine($"Разница между макс и мин элементом - {max} - {min} = {max - min}");
}

Zadacha38();