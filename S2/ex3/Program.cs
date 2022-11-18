// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number == 6 | Number == 7)
    Console.WriteLine("Выходной день!");
    else
    Console.WriteLine("Рабочий");

// Вариант решения задачи через массив. И конкретно какой день.
// Console.WriteLine("Week days!");
// string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
// int index = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Today is {Days[index-1]}");