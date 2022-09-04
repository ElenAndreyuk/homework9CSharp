// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1 (используйте рекурсию).
// N = 5 -> 5, 4, 3, 2, 1

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
void RecursionNumber(int i)
{
    if (i == 1)
    {
        Console.Write($" {i} ");
    }
    else
    {
        Console.Write($" {i} ");
        i--;
        RecursionNumber(i);
    }
}
RecursionNumber(n);