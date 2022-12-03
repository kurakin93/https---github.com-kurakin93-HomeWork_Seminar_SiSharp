//              Задача 41: Пользователь вводит с клавиатуры M чисел. 
//              Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел.");
Console.WriteLine("Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine();
Console.WriteLine("Введите числа с клавиатуры через пробел! ");
string numbers = Console.ReadLine();
int[] arrayNumb = numbers.Split(' ').Select(int.Parse).ToArray();


Console.WriteLine($"Больше 0: {CountGreaterThan0(arrayNumb)}");


int CountGreaterThan0(int[] num)
{
    int count = 0;
    for(int i = 0; i < arrayNumb.Length; i++)
    {
        if(arrayNumb[i] >= 0)
        {
            count++;
        }
    }
    return count;
}