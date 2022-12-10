// 2. Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 1 4 | 2 4
// 2 1 | 2 2
// Результирующая матрица будет:
// 08 10
// 05 08
Console.WriteLine("Input number row matrix1: ");
int rowMatrix1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number columns matrix: ");
int columnsMatrix1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number row matrix2: ");
int rowMatrix2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number columns matrix2: ");
int columnsMatrix2 = Convert.ToInt32(Console.ReadLine());

int[,] arrTable1 = FillArray(rowMatrix1, columnsMatrix1);
int[,] arrTable2 = FillArray(rowMatrix2, columnsMatrix2);
Console.WriteLine("Первая матрица");
PrintArray(arrTable1);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintArray(arrTable2);
Console.WriteLine();
Console.WriteLine("Произведение матриц");
PrintArray(RezultMatrix(arrTable1, arrTable2));

int[,] RezultMatrix(int[,] arr1, int[,] arr2)
{
    int[,] matrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k <= matrix.GetLength(1); k++)
                {
                    matrix[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Невозможно найти произведение двух матриц");
    }
    return matrix;

}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int row, int columns)
{
    int[,] arr = new int[row, columns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = new Random().Next(5);
        }
    }
    return arr;
}