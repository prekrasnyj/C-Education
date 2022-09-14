// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Метод создает матрицу МхN
double[,] CreateRandomMatrix(int m, int n)
{
    double[,] array = new double[m, n];
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
void ShowMatrix(double[,] array)
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

// CountArithmeticMeanOfColumns
double[] CountArithmeticMeanOfColumns(double [,] array)
{
    double [] resMassive = new double [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            resMassive[j] = resMassive[j] + array[i,j];
        }
    }
    for (int i = 0; i < resMassive.Length; i++)
    {
        resMassive[i] = resMassive[i]/array.GetLength(1);
    }
    return resMassive;
}

// Метод Выводит координаты на экран
void ShowCoords(double[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length -1) Console.Write(".");
        else Console.Write("; ");
    
    }
}

Console.WriteLine("Введите кол-во столбцов - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк - ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] newMassive = CreateRandomMatrix(m, n);
ShowMatrix(newMassive);

double[] resMassive = CountArithmeticMeanOfColumns(newMassive);
ShowCoords(resMassive);


