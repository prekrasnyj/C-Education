//Метод выводит массив
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//Метод упорядочивает массив выбором по возрастанию
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporarry = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporarry;
    }
}

//Метод упорядочивает массив выбором по убыванию
void SelectionSortDown(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporarry = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporarry;
    }
}

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
SelectionSortDown(arr);

PrintArray(arr);