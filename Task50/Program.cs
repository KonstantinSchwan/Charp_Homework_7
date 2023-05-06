﻿//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//             и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

matr = new int[3, 4];

FillArray(matr);
PrintArray(matr);

Console.Write($"Введите проверяемое число: ");
int a = int.Parse(Console.ReadLine());
var result = CheckArray(matr, a);
if (result)
{
    Console.Write($"Данное число есть");
}
else
{
    Console.Write($"Данного числа нет");
}