//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

//Метод принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int [] TableCubesNumbers (int n)
{
    int [] table = new int[n];
    int point = 0;
    for(int i = 1; i < n+1; i++)
    {
        table[point] = i*i*i;
        point ++;
    }
    return table;
}

//метод вывода массива в консоль
void ShowMassive(int[] massive, int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(massive[i]);
        Console.Write(" ");
    }
}


Console.Write("Введите чило N - ");
int numberN = Convert.ToInt32(Console.ReadLine());

int[] newMassive = TableCubesNumbers(numberN);
ShowMassive(newMassive, numberN);
