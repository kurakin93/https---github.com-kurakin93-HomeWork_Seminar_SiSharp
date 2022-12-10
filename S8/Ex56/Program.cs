// 2. Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка
//int[,] arrTable = {{1, 0, 0, 10}, {1, 1, 0, 10}, {1, 2, 3, 40}};
int[,] arrTable = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};

Console.WriteLine($"Line-----{СomparisonLineSumMin(SummElementsLine(arrTable))}");

int[] SummElementsLine(int[,] arr)
{
    int[] ResultSum = new int[arr.GetLength(0)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            ResultSum[i] = ResultSum[i] + arr[i, j];         
        }
        Console.WriteLine(ResultSum[i]);
    }
    return ResultSum;
}

int СomparisonLineSumMin(int[] arr)
{
    int ResultSum = arr[0];
    int ResultIndex = 0;
    for(int i = 1; i < arr.GetLength(0); i++)
    {
        if(ResultSum > arr[i])
        {
            ResultSum = arr[i];
            ResultIndex = i;
        }        
    }
    return ResultIndex+1;
}