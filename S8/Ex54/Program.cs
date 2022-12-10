﻿// 1. Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// int[,] arr = {{1, 2, -2, -4}, {-2, 3, 0, 23}, {1, 2, 3, 4}};
int[,] arr = {{1, 4, 7, 2, 3, 6}, {5, 9, 2, 3, 1, 4}, {8, 4, 2, 4, 1, 3}};


void SortingElement(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k+1])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k+1];
                    arr[i, k+1] = temp;
                }
            }
        }
    }
}

void PrintArr(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
        }
        Console.WriteLine();
    }
}

SortingElement(arr);
PrintArr(arr);