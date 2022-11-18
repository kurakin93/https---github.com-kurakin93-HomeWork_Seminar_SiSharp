// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 100)
   while (num1 >= 1000) num1 = num1 / 10 ;
      if (num1 > 100 && num1 < 1000)
         Console.WriteLine($"Третья цифра: {num1 % 10}");
else 
   Console.WriteLine("Третьей цифры нет!");