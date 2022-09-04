// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N (используйте рекурсию).

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите начальное число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int n = int.Parse(Console.ReadLine());

int AddNumbers(int m)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + AddNumbers(m + 1);
    }

}
if (m < n)
{
    Console.WriteLine(AddNumbers(m));
}
else
{
    Console.WriteLine("Вы что-то попутали");
}