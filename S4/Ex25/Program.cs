﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В: ");
int numB = Convert.ToInt32(Console.ReadLine());

void Exponentiation()
{
    Console.WriteLine($"Число: {Math.Pow(numA, numB)}");
}

Exponentiation();