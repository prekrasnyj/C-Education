//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


//Метод создает массив из М чисел и заполняется вручную
int [] CreateManualArray(int m)
{
    int [] array = new int [m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");  
        array[i] = Convert.ToInt32(Console.ReadLine());   
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
    Console.WriteLine();
}

//Метод считает, сколько чисел больше 0 введет пользователь
int CountPositiveNumbers(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) {sum++;}

    }
    return sum;
}


Console.WriteLine("Сколько элементов массива вы хотите ввести?");
int M = Convert.ToInt32(Console.ReadLine());

//Выводим рандомный массив
int[] newMassive = CreateManualArray(M);
ShowMassive(newMassive);
int result = CountPositiveNumbers(newMassive);
Console.Write("Колличество чисел > 0 - ");
Console.WriteLine(result);