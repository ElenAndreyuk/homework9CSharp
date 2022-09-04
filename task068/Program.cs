// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Функция Аккермана

// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите начальное число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int n = int.Parse(Console.ReadLine());

int AckermannFunction(int i, int j)
{
    if (i == 0)
    {
        return j + 1;
    }
    if (i > 0 && j == 0)
    {
        return AckermannFunction(i - 1, 1);
    }
    else 
    {
        return AckermannFunction(i - 1, AckermannFunction(i, j - 1));
    }
}
if (m >= 0 && n >= 0)
{
    System.Console.WriteLine(AckermannFunction(m, n));
}
else
{
    System.Console.WriteLine("Эти данные не подходят для функции Аккермана");
}
