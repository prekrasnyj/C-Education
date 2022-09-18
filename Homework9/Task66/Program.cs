// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int FindSummInterval(int sum, int m, int n)
{
    sum = sum + m;
    if (m == n)
    {
        return sum;
    }
    else
    {
        return FindSummInterval(sum, m + 1, n);
    }
}

const int zero = 0;

Console.WriteLine("Введите первое число - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
int n = Convert.ToInt32(Console.ReadLine());

int summa = FindSummInterval(zero, m, n);

Console.WriteLine(summa);