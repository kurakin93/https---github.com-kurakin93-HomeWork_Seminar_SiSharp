﻿// 2. Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Input number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int sum = numberM - numberN;

System.Console.WriteLine(SumNum(numberM, numberN));

int SumNum(int num1, int num2)
{
    if (num1 == num2) return num1;
    else if (num1 < num2) return num2 + SumNum(num1, num2 - 1);
    else return num2 + SumNum(num1, num2 + 1);
}



