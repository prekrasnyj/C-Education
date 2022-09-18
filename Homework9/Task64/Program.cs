// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// Метод заполняет массив числами от N до М
int[] OutputNumbersRecursion(int[] list, int a, int b, int count)
{
    list[count] = a;
    if (a == b)
    {
        return list;
    }
    else
    {
        return OutputNumbersRecursion(list, a + 1, b, count + 1);
    }
}

// Метод выводит массив на экран
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
}

Console.WriteLine("Введите первое число - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
int n = Convert.ToInt32(Console.ReadLine());

int[] finalArray = new int[n - m + 1];

finalArray = OutputNumbersRecursion(finalArray, m, n, 0);
ShowArray(finalArray);