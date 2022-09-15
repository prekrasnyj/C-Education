// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Метод создает матрицу МхN
int[,] CreateRandomMatrix(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

// Метод Выводит матрицу на экран
void ShowMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write("   ");
        }
        Console.WriteLine();
    }
}

// метод поиска МIN в массиве
int FindMinInArray(int [] array)
{
    int min = 11;
    int index = 0;
    for ( int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) 
        {
            min = array[i];
            index = i;            
        }
    }
    return index+1;
}

// метод считает сумму элементов каждой строки и выводит строку с наибольшей суммой
int FindMinSumInLines(int [,] array)
{
    int [ ] list = new int[array.GetLength(0)];
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        list[i] = sum;
        
    }
    int min = FindMinInArray(list);
    return min;
}

Console.Write("Введите кол-во строк - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов - ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] newMassive = CreateRandomMatrix(m, n);
ShowMatrix(newMassive);

int result = FindMinSumInLines(newMassive);
Console.Write(result);
Console.Write(" строка");
