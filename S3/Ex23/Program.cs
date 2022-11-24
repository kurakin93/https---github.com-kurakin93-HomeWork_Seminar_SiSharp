// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число ");
var num1 = Convert.ToInt32(Console.ReadLine());
var num2 = 1;
// for (int num2=1; num2 <= num1; num2++)
while ( num2 <= num1 )
{
    Console.WriteLine(Math.Pow(num2,3)); //Math.Pow(num2,2)
    num2++;
}

