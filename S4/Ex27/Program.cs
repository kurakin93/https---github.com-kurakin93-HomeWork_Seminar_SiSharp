// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetSumNum(numB));
Console.WriteLine($"Колличество цифр: {GetCount(numB)}");
int lenght = GetCount(numB);
Console.WriteLine($"Сумма цифр: {GetSumNum(numB)}");


int GetCount(int count)
{
    int lenght = 0;
    while (count > 0)
    {
        count /=10;
        lenght++;
    }
    return lenght;
}

int GetSumNum(int num)
{
    int sum = 0;
    int count = 1;
    while(count <= lenght)
    {
        sum = sum + num % 10;
        count++;
        num /= 10;
    }
    return sum;
}