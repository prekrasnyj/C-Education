// Напишите программу, которая заполнит спирально массив 4 на 4.

// Метод создает матрицу МхM
int[,] CreateSquareMatrix(int m)
{
    int[,] array = new int[m, m];
    return array;
}

// Метод Выводит матрицу на экран
void ShowMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],5}");
            Console.Write("     ");
        }
        Console.WriteLine();
    }
}

// метод заполяет матрицу MxM по спирали
int[,] FillSpiralMatrix(int[,] matrix, int m)
{
    int circles;
    if (m % 2 == 0)
    {
        circles = m / 2;
    }
    else
    {
        circles = (m + 1) / 2;
    }

    int delta = 0;
    int count = 1;
    while (delta < circles)
    {
        //вправо
        for (int i = 0 + delta; i < m - delta; i++)
        {
            matrix[0 + delta, i] = count;
            count++;
        }
        //вниз
        for (int i = 1 + delta; i < m - delta; i++)
        {
            matrix[i, m - 1 - delta] = count;
            count++;
        }
        //влево
        for (int i = m - 2 - delta; i >= 0 + delta; i--)
        {
            matrix[m - 1 - delta, i] = count;
            count++;
        }
        //вверх
        for (int i = m - 2 - delta; i >= 1 + delta; i--)
        {
            matrix[i, 0 + delta] = count;
            count++;
        }
        delta++;
    }
    return matrix;
}

Console.Write("Введите разммерность матрицы А - ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateSquareMatrix(m);

int[,] spiralMatrix = FillSpiralMatrix(matrix,m);
ShowMatrix(spiralMatrix);