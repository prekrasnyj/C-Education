// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//метод возвращает рандомное число от 10 до 99, если оно ранее не использовалось
int FindUnicRandomDigit(int[,,] array)
{
    int number = 0;
    while (number == 0)
    {
        int cout = 0;
        number = new Random().Next(10, 99);
        for (int k = 0; k < array.GetLength(2); k++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j, k] == number)
                    {
                        number = 0;
                        continue;
                    }
                }
            }
        }

    }
    return number;
}

// Метод создает матрицу МхN
int[,,] CreateRandomMatrix(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j, k] = FindUnicRandomDigit(array);
            }
        }
    }
    return array;
}

// Метод Выводит матрицу на экран
void ShowMatrix(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j, k]);
                Console.Write($"({i},{j},{k})");
                Console.Write("   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите кол-во строк - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов - ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во слоев - ");
int l = Convert.ToInt32(Console.ReadLine());


if (n * m * l > 89) { Console.WriteLine("вы вышли за предел чисел"); }
else
{
    int[,,] newMatrix = CreateRandomMatrix(m, n, l);
    ShowMatrix(newMatrix);
}



