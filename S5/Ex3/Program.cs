// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
int[] array = FillArray(50);
Print(array);
Console.WriteLine();
Console.WriteLine($"Минимальное число: {MinNum(array)}   Максимальное число: {MaxNum(array)} ");
Console.WriteLine($"Разница чисел: {MaxNum(array) - MinNum(array)}");



int MaxNum(int[] array)
{
    int MxNum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > MxNum)
        {
            MxNum = array[i];
        }
    }
    return MxNum;
}


int MinNum(int[] array)
{
    int MnNum = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < MnNum)
        {
            MnNum = array[i];
        }
    }
    return MnNum;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(50, 100);
    }
    return array;
}

void Print(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
    Console.Write($"{arr[i]} ");
    }
}