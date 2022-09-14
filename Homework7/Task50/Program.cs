// Напишите программу, которая на вход принимает число и ищет в двумерном массиве,
// и возвращает индексы этого элемента или же указание, что такого элемента нет.

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

//метод узнает сколько раз число встречается в массиве
int HowMany(int[,] array, int target)
{   
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == target) {count++;}
        }
    }
    return count;
}

//метод создает массив с координатами таргетов
int [] FindTargets(int [,] array, int count, int target)
{
    int [] resArray = new int[count*2];
    int x = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            while (x != count*2)
            {
                if (array[i,j] == target) 
                {
                    resArray[x] = i;
                    x++;
                    resArray[x]=j;
                    x++;
                }
                break;
            }
        }
    }
    return resArray;
}

// Метод Выводит координаты на экран
void ShowCoords(int[] array)
{
    if (array.Length == 0) Console.Write("нет такого элемента");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write(array[i]);
            count ++;
            if (count % 2 == 1) Console.Write(",");
            if (count % 2 == 0) Console.Write("   ");
    }
}

Console.WriteLine("Введите кол-во столбцов - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк - ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Какое  число вы хотите проверить на наличие? - ");
int target = Convert.ToInt32(Console.ReadLine());

int[,] newMassive = CreateRandomMatrix(m, n);
ShowMatrix(newMassive);

int[] coordsList = FindTargets(newMassive, HowMany(newMassive,target), target);
ShowCoords(coordsList);

