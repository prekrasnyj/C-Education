// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Метод создает матрицу МхN
double[,] CreateRandomMatrix(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
        }
    }
    return array;
}

// Метод Выводит матрицу на экран
void ShowMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j],1));
            Console.Write("   ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите кол-во столбцов - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк - ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] newMassive = CreateRandomMatrix(m, n);
ShowMatrix(newMassive);