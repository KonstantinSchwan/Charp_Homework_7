﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matr = new int[3, 4];


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


bool CheckArray(int[,] matr, int a)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == a) return true;
        }
    }
    return false;
}


float[] MidSumArray(int[,] matr)
{
    float[] middlesum = new float[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            middlesum[j] += matr[i,j];
        }
        middlesum[j] /= matr.GetLength(0);
    }
    return middlesum;
}

void PrintArrayMidSum(float[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine($"Среднее арифметическое столбца №{i+1} = {a[i]}");
    }
}

matr = new int[3, 4];

FillArray(matr);
PrintArray(matr);
var result = MidSumArray(matr);
PrintArrayMidSum(result);