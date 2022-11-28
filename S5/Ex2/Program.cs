// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = FillArray(10);
Print(array);
Console.WriteLine();
Console.WriteLine(SumOddNum(array));

int SumOddNum(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if( i % 2 == 1 )
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}




int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(5);
    }
    return array;
}

void Print(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write($"{array[i]} ");
    
    }
}