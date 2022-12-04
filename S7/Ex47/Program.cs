// 1. Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Задайте двумерный массив размером m*n. ");
Console.WriteLine("Input number lines: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number columns: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] arrayNumber = new double[numberM, numberN];
var random = new Random();

PrintArray(numberM, numberN);

void PrintArray(int numberM, int numberN)
{
    double[,] arrNum = new double[numberM, numberN];
    for(int i = 0; i < arrNum.GetLength(0); i++)
    {
        for(int j = 0; j < arrNum.GetLength(1); j++)
        {
            arrNum[i, j] = random.Next(-5, 5);
            Console.Write($" {1/arrNum[i,j]} ");
        }
        Console.WriteLine();
    }
    
}