
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



int[] array = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25};
int low = 0;
int high = array.Length - 1;
int mid = 0;
Console.WriteLine("Введите число от 1 до 25");
int findNum = Convert.ToInt32(Console.ReadLine());

while(array[mid] != findNum)
{
    mid = low + (high - low) / 2;
    if(findNum < array[mid])
    {
        high = mid - 1;
    }
    else if(findNum > array[mid])
    {
        low = mid + 1;
    }
}
Console.WriteLine($"Позиция числа: {findNum}  Позиция: {mid}");
// Console.WriteLine("Позиция числа " + findNum + " - № = " + mid);