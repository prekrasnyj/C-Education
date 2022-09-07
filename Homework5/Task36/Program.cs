//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// Метод создает массив из N элементов, заполняя его раедомными числамии от 100 до 999
int [] RandomArray(int n)
{
    int [] array = new int [n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(10,100);        
    }
    return array;
}

//метод вывода массива в консоль
void ShowMassive(int[] massive)
{
    int n = massive.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write(massive[i]);
        if (i < n-1) Console.Write(", ");
    }
}

//метод ищет кол-во четных чисел в массиве
int FindSummOfUneven (int[] massive)
{
    int sum = 0;
    int length = massive.Length;
    for (int i = 0; i < length; i++)
    {
        if ((i%2) == 0) sum = sum + massive[i];
    }
    
    return sum;
}

//Задаем кол-во элементов массива
Console.Write("Введите кол-во элементов массива - ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
//Выводим рандомный массив
int[] newMassive = RandomArray(numberOfElements);
Console.Write("[");
ShowMassive(newMassive);
Console.WriteLine("]");
//Ищем сумму элементов, стоящих на нечётных позициях
int summ = FindSummOfUneven(newMassive);
Console.WriteLine(summ);