// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

//метод перемножает две матрицы
int[,] МultiplyMatrices(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int [arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayC[i,j] = 0;
            for (int k = 0; k < arrayA.GetLength(0); k++)
            {
                arrayC[i,j] = arrayC[i,j] + (arrayA[i,k]*arrayB[k,j]);
            }
        }
    }
    return arrayC;
}

Console.WriteLine("Введите кол-во строк матрицы А - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы А - ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк матрицы В - ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы В - ");
int k = Convert.ToInt32(Console.ReadLine());

int[,] newMassiveA = CreateRandomMatrix(m, n);
ShowMatrix(newMassiveA);
Console.WriteLine();

int[,] newMassiveB = CreateRandomMatrix(l, k);
ShowMatrix(newMassiveB);
Console.WriteLine();

if (n != l) {Console.WriteLine("Эти матрицы нельзя перемножить");}
else
{
    int[,] newMassiveC = МultiplyMatrices(newMassiveA, newMassiveB);
    ShowMatrix(newMassiveC);
}