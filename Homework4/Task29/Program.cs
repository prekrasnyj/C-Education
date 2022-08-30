//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//Программа сделана, чтобы она создавала иассив из N элементов

// Метод создает массив из N элементов, заполняя его раедомными числамии от 1 до 10
int [] RandomArray(int n)
{
    int [] array = new int [n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1,10);        
    }
    return array;
}

//метод вывода массива в консоль
void ShowMassive(int[] massive, int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(massive[i]);
        if (i < n-1) Console.Write(", ");
    }
}

Console.Write("Введите кол-во элементов массива - ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());

int[] newMassive = RandomArray(numberOfElements);
Console.Write("[");
ShowMassive(newMassive, numberOfElements);
Console.WriteLine("]");

