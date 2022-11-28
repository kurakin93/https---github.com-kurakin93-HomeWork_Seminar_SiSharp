

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = FillArray(15);
Print(array);
Console.WriteLine();
Console.WriteLine(EvenNum(array));


int EvenNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
        
    }
    return count;
}




int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i=0; i < length; i++)
    {
        array[i] = new Random().Next(100, 999);
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