// 4. Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



PrintArray(FindReplayNumber(FillArray(2,2,2)));

int[,,] FindReplayNumber(int[,,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                int temp = arr[i, j, k];
                if(temp == arr[i, j, k+1])
                {
                    arr[i, j, k+1] = new Random().Next(5);
                }
                
            }
        }
    }
    return arr;
}



int[,,] FillArray(int axisX, int axisY, int axisZ)
{
    int[,,] arr = new int[axisX, axisY, axisZ];
    for (int i = 0; i < axisX; i++)
    {
        for (int j = 0; j < axisY; j++)
        {
            for (int k = 0; k < axisZ; k++)
            {
                arr[i, j, k] = new Random().Next(5);
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} -- ({i}{j}{k}) ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}