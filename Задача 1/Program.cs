﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
using System;
using static System.Console;
Clear();

int InputNum(string message)
{
    Write(message);
    return Convert.ToInt32(ReadLine());
}

double[,] SetArray2Double(int line, int column)
{
    double[,] numArr2D = new double[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            numArr2D[i, j] = new Random().Next(0, 100) + new Random().NextDouble(); 
            numArr2D[i, j] = Math.Round(numArr2D[i, j], 2); 
        }
    }
    return numArr2D;
}
void PrintArray2Double(double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Write(array2D[i, j] + " ");
        }
        WriteLine();
    }
}

int m = InputNum("Задайте количествово строк: ");
int n = InputNum("Задайте количествово столбцов: ");

double[,] array = SetArray2Double(m, n);

WriteLine($"Массив {m}x{n}:");
PrintArray2Double(array);