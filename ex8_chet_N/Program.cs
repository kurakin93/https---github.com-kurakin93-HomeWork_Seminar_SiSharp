// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Input number");
int num1 = Convert.ToInt32(Console.ReadLine());

while(1 <= num1)
{
    if(num1%2 == 0)
    Console.WriteLine(num1);    
    num1--;      
    }
