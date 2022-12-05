// 3. Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте двумерный массив размером m*n. ");
Console.WriteLine("Введите колличество строк: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество колонок: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
var random = new Random();
int[,] arrayTable = PrintArray(numberM, numberN);
Console.Write("Выберите среднее арифметическое в каждом столбце - 1, либо в каждой строке - 2! ");
Console.WriteLine();
START:
int choice = int.Parse(Console.ReadLine());


switch (choice)
{
    case 1:
        GetAverageColums(arrayTable);
        break;
    case 2:
        GetAveragelines(arrayTable);
        break;
    default:
        Console.Write("Не верный выбор, повторите ввод: ");
        goto START;
}


void GetAverageColums(int[,] arrNum)
{
    double[] arrNumAverage = new double[arrNum.GetLength(0)];
    for(int j = 0; j < arrNum.GetLength(1); j++)
    {
        for(int i = 0; i < arrNum.GetLength(0); i++)
        {
            arrNumAverage[j] = arrNumAverage[j] + arrNum[i, j];
        }
        arrNumAverage[j] = arrNumAverage[j] / arrNum.GetLength(0);
        Console.WriteLine($"Столбец {j+1} = {arrNumAverage[j]}");
    }
    // Console.WriteLine(arrNumAverage[j]);
}

void GetAveragelines(int[,] arrNum)
{
    double[] arrNumAverage = new double[arrNum.GetLength(1)];
    for(int j = 0; j < arrNum.GetLength(0); j++)
    {
        for(int i = 0; i < arrNum.GetLength(1); i++)
        {
            arrNumAverage[j] = arrNumAverage[j] + arrNum[j, i];
        }
        arrNumAverage[j] = arrNumAverage[j] / arrNum.GetLength(1);
        Console.WriteLine($"Строка {j+1} = {arrNumAverage[j]}");
    }
    // Console.WriteLine(arrNumAverage[j]);
}


int[,] PrintArray(int numberM, int numberN)
{
    int[,] arrNum = new int[numberM, numberN];
    for(int i = 0; i < arrNum.GetLength(0); i++)
    {
        for(int j = 0; j < arrNum.GetLength(1); j++)
        {
            arrNum[i, j] = random.Next(10);
            Console.Write($" {arrNum[i,j]} ");
        }
        Console.WriteLine();
    }
    return arrNum;
    
}

