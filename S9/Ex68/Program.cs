// 3. Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29




Console.WriteLine("Введите неотрицательное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Значение {FunctionAkkerman(numberM, numberN)} ");


int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}