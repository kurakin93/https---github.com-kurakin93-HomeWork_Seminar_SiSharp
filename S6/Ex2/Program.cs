// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// // y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, 
// k1 = 5, 
// b2 = 4, 
// k2 = 9 -> 
// (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double numB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double numK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double numB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double numK2 = Convert.ToInt32(Console.ReadLine());
doubleersectionPodouble(numB1, numK1, numB2, numK2);

void doubleersectionPodouble(double numB1, double numK1, double numB2, double numK2)
{
    if(numK1 == numK2)
    {
        Console.WriteLine("Прямые параллельны.");
    }
    else if(numK1 == -(1/numK2))
    {
        double y = (numK2*numB1-numK1*numB2)/(numK2-numK1);
        double x = (numB1-numB2)/(numK2-numK1);
        Console.WriteLine($"Прямые перпендикулярны. Точка пересечения ({y},{x})");
    }
    else
    {
    double y = (numK2*numB1-numK1*numB2)/(numK2-numK1);
    double x = (numB1-numB2)/(numK2-numK1);
    Console.WriteLine($"Точка пересечения ({y},{x})");
    }
}