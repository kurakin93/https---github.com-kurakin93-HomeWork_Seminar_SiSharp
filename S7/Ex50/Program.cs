// 2. Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("Введи позицию элемента: ");
int numPositionI = Convert.ToInt32(Console.ReadLine());
int numPositionJ = Convert.ToInt32(Console.ReadLine());
int[,] arrayTable = {{1, 2, -2, -4}, {-2, 3, 0, 23}, {1, 2, 3, 4}};
FindNumber(arrayTable);

void FindNumber(int[,] arrNum)
{
    if(numPositionI > arrayTable.GetLength(0) | numPositionJ > arrayTable.GetLength(1))
    {
        Console.WriteLine($"Такого числа нет! ");
    }
    else Console.WriteLine($" {arrayTable[numPositionI, numPositionJ]} ");
}