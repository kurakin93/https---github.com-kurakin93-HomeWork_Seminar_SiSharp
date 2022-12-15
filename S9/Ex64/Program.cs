// 1. Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
OutNum(number);

int OutNum(int n)
{
    if(n == 1) return 1;
    else return OutNum(n - 1);
}
for(int i = number; i >= 1; i--)
{
    System.Console.WriteLine($"{i}");
}