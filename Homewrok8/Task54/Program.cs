// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

// метод сортировки одномерного массива
void SelectionSortDown(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporarry = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporarry;
    }
}

// Метод соритует строки по убыванию в двумерном массиве
void SortLineInMatrix(int[,] array)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        int [ ] list = new int[array.GetLength(1)];
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            list[j] = array[i,j];
        }
        SelectionSortDown(list);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = list[j];
        }
        
    }
    
}

Console.WriteLine("Введите кол-во строк - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов - ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] newMassive = CreateRandomMatrix(m, n);
ShowMatrix(newMassive);

SortLineInMatrix(newMassive);
Console.WriteLine();
ShowMatrix(newMassive);
