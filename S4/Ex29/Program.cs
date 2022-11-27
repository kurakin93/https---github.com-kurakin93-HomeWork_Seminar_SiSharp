// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

var array = FillArray(8);
Print(array);



int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i=0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void Print(int[] array)
{
    for(int i=0; i < array.Length; i++)
    
    // foreach(var item in array)
    {
        Console.Write($"{array[i]} ");
    }
}